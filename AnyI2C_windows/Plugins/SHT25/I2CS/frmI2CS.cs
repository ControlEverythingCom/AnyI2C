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

namespace SHT25_I2CS
{
    public partial class frmI2CS : Form
    {
        CommInterface CommObj = null;
        public frmI2CS()
        {
            InitializeComponent();
        }

        private void frmADC081C_Load(object sender, EventArgs e)
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
            if (Read)
            {
                return (byte)(numAddress.Value * 2 + 1);
            }
            return (byte)(numAddress.Value * 2);
        }

        private string ReadSensor()
        {
            try
            {
                _ERROR.Visible = false;
                byte addr = GetAddress(false);
                // Read Humidity
                int retry = 0;
                bool success = false;
                while (!success && retry < 10)   // try 10 times
                {
                    byte[] value = CommObj.Send(new byte[] { addr, 0xf5 }, 0);
                    Thread.Sleep(100);
                    value = CommObj.Send(new byte[] { addr }, 3);
                    if (value != null)
                    {
                        if (value.Length == 3)
                        {
                            success = true;
                            double humidity = 125.0 * (value[0] * 256 + value[1]) / (Math.Pow(2,16)) - 6.0;
                            lbH.Text = humidity.ToString("F2");
                            break;
                        }
                        
                    }
                    Thread.Sleep(100);
                    retry++;
                }

                retry = 0;
                success = false;
                // read temperature
                while (!success && retry < 10)   // try 10 times
                {
                    byte[] value = CommObj.Send(new byte[] { addr, 0xf3 }, 0);
                    Thread.Sleep(100);
                    value = CommObj.Send(new byte[] { addr }, 3);

                    if (value != null)
                    {
                        if (value.Length == 3)
                        {
                            success = true;
                            double temp = 175.72 * (value[0] * 256 + value[1]) / (Math.Pow(2, 16)) - 46.85;
                            lbT.Text = temp.ToString("F2");
                            break;
                        }
                    }
                    retry++;
                    Thread.Sleep(100);
                }

                

            }
            catch
            {
                _ERROR.Visible = true;
            }

            return "Error";
        }

        private void btnReadCh0_Click(object sender, EventArgs e)
        {
            ReadSensor();
        }

        private void frmI2CS_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            CommObj.LogText("GUI Closed");
        }

        private void numPort_ValueChanged(object sender, EventArgs e)
        {
            CommObj.SetPort((byte)numPort.Value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ReadSensor();
        }

        private void chkAutoUpdate_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = chkAutoUpdate.Checked;
            btnReadCh.Enabled = !chkAutoUpdate.Checked;
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
