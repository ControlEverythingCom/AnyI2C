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

namespace LSM330_I2CS
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
                //config the sensor
                CommObj.Send(new byte[] { addr, 0x20, 23 }, 0);
                CommObj.Send(new byte[] { addr, 0x23, 0 }, 0);
                Thread.Sleep(100);
                byte[] value = CommObj.Send(new byte[] { addr, 0x28 }, 6);
                if (value != null)
                {
                    if (value.Length == 6)
                    {
                        lbX.Text = ((value[1] * 256 + value[0]) > 32767) ? (((value[1] * 256 + value[0]) - 65536).ToString()) : ((value[1] * 256 + value[0]).ToString());
                        lbY.Text = ((value[3] * 256 + value[2]) > 32767) ? (((value[3] * 256 + value[2]) - 65536).ToString()) : ((value[3] * 256 + value[2]).ToString());
                        lbZ.Text = ((value[5] * 256 + value[4]) > 32767) ? (((value[5] * 256 + value[4]) - 65536).ToString()) : ((value[5] * 256 + value[4]).ToString());
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
