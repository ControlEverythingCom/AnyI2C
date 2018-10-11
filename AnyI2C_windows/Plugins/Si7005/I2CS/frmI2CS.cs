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

namespace Si7005_I2CS
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
            return (byte)(numAddress.Value);
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
                byte[] value = CommObj.Send(new byte[] { addr, 3, 1 }, 0);
                while (!success && retry < 10)   // try 10 times
                {
                    value = CommObj.Send(new byte[] { addr, 0 }, 1);
                    if (value != null)
                    {
                        if (value.Length == 1)
                        {
                            if ((value[0] & 1) == 0)
                            {
                                value = CommObj.Send(new byte[] { addr, 1 }, 2);
                                success = true;
                                double humidity = ((value[0]&0xF) * 256  + value[1]) / 16.0 -24;
                                lbH.Text = humidity.ToString("F2");
                                break;
                            }
                        }
                        
                    }
                    Thread.Sleep(100);
                    retry++;
                }

                retry = 0;
                success = false;
                value = CommObj.Send(new byte[] { addr, 3, 0x11 }, 0);
                while (!success && retry < 10)   // try 10 times
                {
                    value = CommObj.Send(new byte[] { addr, 0 }, 1);
                    if (value != null)
                    {
                        if (value.Length == 1)
                        {
                            if ((value[0] & 1) == 0)
                            {
                                value = CommObj.Send(new byte[] { addr, 1 }, 2);
                                success = true;
                                double temp = ((value[0] & 0x3F) * 256 + value[1]) / 32.0 - 50;
                                lbT.Text = temp.ToString("F2");
                                break;
                            }
                        }

                    }
                    Thread.Sleep(100);
                    retry++;
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
