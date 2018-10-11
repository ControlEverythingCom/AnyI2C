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

namespace TMD2671_I2CS
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

        private void ReadSensor()
        {
            try
            {
                _ERROR.Visible = false;
                byte addr = GetAddress(false);
                // power on and measure
                // write to config
                byte[] value = CommObj.Send(new byte[] { addr, 0x02 | 0x80, 0xFF }, 0);
                value = CommObj.Send(new byte[] { addr, 0x03 | 0x80, 0xFF }, 0);
                value = CommObj.Send(new byte[] { addr, 0x0E | 0x80, 0X20 }, 0);
                value = CommObj.Send(new byte[] { addr, 0x0F | 0x80, 0x20 }, 0);
                value = CommObj.Send(new byte[] { addr, 0x00 | 0x80, 0x0F }, 0);
                Thread.Sleep(800);
                value = CommObj.Send(new byte[] { addr, 0x18 | 0x80 }, 2);
                if (value != null)
                {
                    int proximity = (((value[1] & 0xFF) * 256) + (value[0] & 0xFF));
                    lbProx.Text = proximity.ToString();
                }
                else {
                
                    lbProx.Text = "Error";
                }
            }
            catch
            {
                _ERROR.Visible = true;
            }

            
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
