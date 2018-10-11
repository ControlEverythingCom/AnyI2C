using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using AnyI2C;

namespace HTS221_I2CS
{
    public partial class frmI2CS : Form
    {
        CommInterface CommObj = null;
        public frmI2CS()
        {
            InitializeComponent();
        }

        private void frmI2CS_Load(object sender, EventArgs e)
        {
            CommObj.LogText("GUI Opened");
            numAddress.Value = CommObj.GetDefaultAddress();
            numPort.Value = CommObj.GetPort();
        }

        public void Attach(CommInterface com)
        {
            CommObj = com;
        }

        /// <summary>
        /// Send command, will process address
        /// </summary>
        private byte GetAddress(bool Read)
        {
            return (byte)(numAddress.Value);
        }

        private string ReadSensor()
        {
            try
            {
                _ERROR.Visible = false;
                byte addr = GetAddress(false);
                // Select average configuration register
                byte[] value = CommObj.Send(new byte[] { addr, 0x10, 0x1B }, 0);
                // Select control register1
                // Power on
                value = CommObj.Send(new byte[] { addr, 0x10, 0x1B }, 0);
                Thread.Sleep(500);
                // Read Humidity calliberation values
                byte[] val1 = CommObj.Send(new byte[] { addr, 0x30 }, 1);
                byte[] val2 = CommObj.Send(new byte[] { addr, 0x31 }, 1);
                double H0 = (val1[0] & 0xFF) / 2;
                double H1 = (val2[0] & 0xFF) / 2;

                val1 = CommObj.Send(new byte[] { addr, 0x36 }, 1);
                val2 = CommObj.Send(new byte[] { addr, 0x37 }, 1);
                double H2 = ((val2[0] & 0xFF) * 256) + (val1[0] & 0xFF);

                val1 = CommObj.Send(new byte[] { addr, 0x3A }, 1);
                val2 = CommObj.Send(new byte[] { addr, 0x3B }, 1);
                double H3 = ((val2[0] & 0xFF) * 256) + (val1[0] & 0xFF);

                //Read Temperature calliberation values
                val1 = CommObj.Send(new byte[] { addr, 0x32 }, 1);
                val2 = CommObj.Send(new byte[] { addr, 0x33 }, 1);
                double T0 = (val1[0] & 0xFF);
                double T1 = (val2[0] & 0xFF);

                value = CommObj.Send(new byte[] { addr, 0x35 }, 1);
                // Convert the temperature calliberation values to 10-bits
                T0 = ((value[0] & 0x03) * 256) + T0;
                T1 = ((value[0] & 0x0C) * 64) + T1;

                val1 = CommObj.Send(new byte[] { addr, 0x3C }, 1);
                val2 = CommObj.Send(new byte[] { addr, 0x3D }, 1);
                double T2 = ((val2[0] & 0xFF) * 256) + (val1[0] & 0xFF);

                val1 = CommObj.Send(new byte[] { addr, 0x3E }, 1);
                val2 = CommObj.Send(new byte[] { addr, 0x3F }, 1);
                double T3 = ((val2[0] & 0xFF) * 256) + (val1[0] & 0xFF);

                // Read 4 bytes of data
                value = CommObj.Send(new byte[] { addr, 0xA8 }, 4);
                if (value != null)
                {
                    if (value.Length == 4)
                    {
                        double hum = ((value[1] & 0xFF) * 256) + (value[0] & 0xFF);
                        double temp = ((value[3] & 0xFF) * 256) + (value[2] & 0xFF);
                        if (temp > 32767)
                        {
                            temp -= 65536;
                        }
                        double humidity = ((1.0 * H1) - (1.0 * H0)) * (1.0 * hum - 1.0 * H2) / (1.0 * H3 - 1.0 * H2) + (1.0 * H0);
                        double cTemp = ((T1 - T0) / 8.0) * (temp - T2) / (T3 - T2) + (T0 / 8.0);
                        lbT.Text = cTemp.ToString("F2");
                        lbH.Text = humidity.ToString("F2");
                    }
                }
            }
            catch
            {
                _ERROR.Visible = true;
            }

            return "Error";
        }

        private void frmI2CS_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommObj.LogText("GUI Closed");
        }

        private void numPort_ValueChanged(object sender, EventArgs e)
        {
            CommObj.SetPort((byte)numPort.Value);
        }

        private void btnReadCh0_Click(object sender, EventArgs e)
        {
            ReadSensor();
        }
    }

    public class MyGUI : GuiInterface
    {
        public void Show(CommInterface com)
        {
            frmI2CS frm = new frmI2CS();
            frm.Attach(com);
            frm.ShowDialog();
        }
    }
}
