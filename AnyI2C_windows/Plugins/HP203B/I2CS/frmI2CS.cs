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

namespace HP203B_I2CS
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

        double ReadUnsignedShort(byte RegAddr)
        {
            byte addr = GetAddress(true);
            byte[] value = CommObj.Send(new byte[] { addr, RegAddr }, 2);
            if (value != null)
            {
                if (value.Length == 2)
                {
                    return value[0] * 256 + value[1];
                }
            }
            throw new Exception("Error Read");
        }

        double ReadSignedShort(byte RegAddr)
        {
            byte addr = GetAddress(true);
            byte[] value = CommObj.Send(new byte[] { addr, RegAddr }, 2);
            if (value != null)
            {
                if (value.Length == 2)
                {
                    if (value[0] < 128)
                    {
                        return value[0] * 256 + value[1];
                    }
                    else
                    {
                        return value[0] * 256 + value[1] - 65536;
                    }
                }
            }
            throw new Exception("Error Read");
        }


        private string ReadSensor()
        {
            try
            {
                _ERROR.Visible = false;

                byte addr = GetAddress(false);
                // measure temperature and pressure
                byte[] value = CommObj.Send(new byte[] { addr, 0x40}, 0);
                Thread.Sleep(500);
                value = CommObj.Send(new byte[] { addr, 0x10}, 6);
                double temp = 0;
                if ((value[0] & 0x8) == 0)
                {
                    temp = ((value[0] & 0x7) * 256 * 256 + value[1] * 256 + value[2]) / 100.0;
                }
                else // neg value
                {
                    temp = ((value[0] & 0x7) * 256 * 256 + value[1] * 256 + value[2] - Math.Pow(2, 20)) / 100.0;
                }

                double pressure = ((value[3] & 0xf) * 256 * 256 + value[4] * 256 + value[5])/100.0;
                lbT.Text = temp.ToString("F2");
                lbP.Text = pressure.ToString("F2");
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            ReadSensor();
        }

        private void chkAutoUpdate_CheckedChanged(object sender, EventArgs e)
        {
            btnReadCh0.Enabled = !chkAutoUpdate.Checked;
            if (chkAutoUpdate.Checked)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void lbP_Click(object sender, EventArgs e)
        {

        }

        private void frmI2CS_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
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
            frmI2CS frm = new frmI2CS();
            frm.Attach(com);
            frm.ShowDialog();
        }
    }

}
