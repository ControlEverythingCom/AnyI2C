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

namespace HYT939_I2CS
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
                for (int i = 0; i < 10; i++)
                {
                    byte addr = GetAddress(false);
                    byte[] value = CommObj.Send(new byte[] { addr, 0x80 }, 0);
                    value = CommObj.Send(new byte[] { addr, 0 }, 4);
                    if (value != null)
                    {
                        if (value[0] != 0x7f)
                        {
                            double t = ((value[2] * 256) + (value[3] & 0xFC)) / 4;
                            double temp = ((165.0 / (16383.0)) * t) - 40;
                            lbCh0.Text = temp.ToString("F2");
                            double h = (((value[0] & 0x3F) * 256) + value[1]);
                            double humidity = (100.0 / (16383.0)) * h;
                            lbCh1.Text = humidity.ToString("F2");
                            return "";
                        }
                    }
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
            CommObj.LogText("GUI Closed");
        }

        private void numPort_ValueChanged(object sender, EventArgs e)
        {
            CommObj.SetPort((byte)numPort.Value);
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
