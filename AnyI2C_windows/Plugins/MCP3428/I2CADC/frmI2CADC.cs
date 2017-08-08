using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AnyI2C;

namespace MCP3428_I2CADC
{
    public partial class frmI2CADC : Form
    {
        CommInterface CommObj = null;
        public frmI2CADC()
        {
            InitializeComponent();
        }

        private void frmMCP3426_Load(object sender, EventArgs e)
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

        private string ReadCh(byte ch)
        {
            try
            {
                _ERROR.Visible = false;
                byte addr = GetAddress(false);
                for (int i = 0; i < 8; i++)  // try 8 times
                {
                    byte[] value = CommObj.Send(new byte[] { addr, ch }, 3);
                    if (value != null)
                    {
                        if ((value[2] & 128) == 0)       // valid data with 7bit of third byte is 0
                        {
                            if (value[0] < 128)
                            {
                                int v = value[0] * 256 + value[1];
                                return GetText(v);
                            }
                            else
                            {
                                int v = (value[0] * 256 + value[1] - 65535);
                                return GetText(v);
                            }
                        }
                        else
                        {
                            Debug.Print("Invalid data read");
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
            lbCh0.Text = ReadCh(152);
        }

        private void btnReadCh1_Click(object sender, EventArgs e)
        {
            lbCh1.Text = ReadCh(184);
        }

        /// <summary>
        /// Get description text 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private string GetText(int value)
        {
            double v = (double)value/ 32768.0;    // normalize to 0 - 10
            double v5 = v * 5.0;
            double v10 = v * 10.0;
            double v20 = v * 20.0;
            double v24 = v * 24.0;
            string str = string.Format("{0}/32768  {1:F2}/5V   {2:F2}/10V   {3:F2}/20V   {4:F2}/24V", value, v5, v10, v20, v24);
            return str;
        }


        private void btnSetup_Click(object sender, EventArgs e)
        {
            byte addr = GetAddress(true);
            CommObj.Send(new byte[] { addr, 152 }, 0);
            CommObj.LogText("GUI Initialize Complete");
        }

        private void btnReadCh2_Click(object sender, EventArgs e)
        {
            lbCh2.Text = ReadCh(216);
        }

        private void btnReadCh3_Click(object sender, EventArgs e)
        {
            lbCh3.Text = ReadCh(248);
        }

        private void frmI2CS_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommObj.LogText("GUI Closed");
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            CommObj.SetPort((byte)numPort.Value);
        }
    }


    public class MyGUI : GuiInterface
    {
        public void Show(CommInterface com)
        {
            frmI2CADC frm = new frmI2CADC();
            frm.Attach(com);
            frm.ShowDialog();
        }
    }

}
