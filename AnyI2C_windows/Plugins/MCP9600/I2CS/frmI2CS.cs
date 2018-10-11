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

namespace MCP9600_I2CS
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
            cmbType.SelectedIndex = 0;
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

        private string ReadTemperature()
        {
            string str = string.Empty;
            try
            {
                
                _ERROR.Visible = false;
                byte addr = GetAddress(false);
                CommObj.Send(new byte[] { addr, 4, 0 }, 0);// clear status register

                CommObj.Send(new byte[] { addr, 5, (byte)(cmbType.SelectedIndex * 16) }, 0);// configure the type
                System.Threading.Thread.Sleep(100);
                CommObj.Send(new byte[] { addr, 6, 0xfc}, 0);// configure the device
                System.Threading.Thread.Sleep(100);
                byte[] value = CommObj.Send(new byte[] { addr, 4 }, 1);
                if (value!= null)
                {
                    if ((value[0] & 0x40) == 0x40) // complete conversion
                    {
                        value = CommObj.Send(new byte[] { addr, 0 }, 2);
                        if (value != null)
                        {
                            if ((value[0] & 0x80) == 0x80)
                            {
                                str =  ((value[0] & 0x7f) * 16 + value[1] / 16.0 - 1024).ToString("F2");
                            }
                            else
                            {
                                str = (value[0] * 16 + value[1] / 16.0).ToString("F2");
                            }
                        }

                        value = CommObj.Send(new byte[] { addr, 1 }, 2);
                        if (value != null)
                        {
                            if ((value[0] & 0x80) == 0x80)
                            {
                                str = ((value[0] & 0x7f) * 16 + value[1] / 16.0 - 1024).ToString("F2");
                            }
                            else
                            {
                                str = (value[0] * 16 + value[1] / 16.0).ToString("F2");
                            }
                        }

                        value = CommObj.Send(new byte[] { addr, 2 }, 2);
                        if (value != null)
                        {
                            if ((value[0] & 0x80) == 0x80)
                            {
                                str =  ((value[0] & 0x7f) * 16 + value[1] / 16.0 - 1024).ToString("F2");
                            }
                            else
                            {
                                str = (value[0] * 16 + value[1] / 16.0).ToString("F2");
                            }
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
            lbCh0.Text = ReadTemperature();
        }

        private void frmI2CS_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommObj.LogText("GUI Closed");
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            CommObj.SetPort((byte)numPort.Value);
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

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
