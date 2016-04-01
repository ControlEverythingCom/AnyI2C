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

namespace MMA7660FC_I2CS
{
    public partial class frmI2CS : Form
    {
        CommInterface CommObj = null;
        public frmI2CS()
        {
            InitializeComponent();
        }

        private void MMA7660FC_Load(object sender, EventArgs e)
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
                //config the sensor
                byte[] value = CommObj.Send(new byte[] { addr, 0x07, 0x01 }, 0);
                value = CommObj.Send(new byte[] { addr, 0x00 }, 3);
                if (value != null)
                {
                    if (value.Length == 3)
                    {
                        lbX.Text = ((value[0] & 0x3f) > 31) ? ((value[0] & 0x3f) - 64).ToString() : (value[0] & 0x3f).ToString();
                        lbY.Text = ((value[1] & 0x3f) > 31) ? ((value[1] & 0x3f) - 64).ToString() : (value[1] & 0x3f).ToString();
                        lbZ.Text = ((value[2] & 0x3f) > 31) ? ((value[2] & 0x3f) - 64).ToString() : (value[2] & 0x3f).ToString();
                    }
                }
                return "OK";
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

        private void timer1_Tick(object sender, EventArgs e)
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
