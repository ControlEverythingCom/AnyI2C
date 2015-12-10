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

namespace HMC6343_I2CS
{
    public partial class frmI2CS : Form
    {
        CommInterface CommObj = null;
        public frmI2CS()
        {
            InitializeComponent();
        }

        private void L3G4200_Load(object sender, EventArgs e)
        {
            numAddress.Value = CommObj.GetDefaultAddress();

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
                byte[] value = CommObj.Send(new byte[] { addr,0x40}, 6);
                if (value != null )
                {
                    if (value.Length == 6)
                    {
                        lbAX.Text = (value[0] * 256 + value[1]).ToString();
                        lbAY.Text = (value[2] * 256 + value[3]).ToString();
                        lbAZ.Text = (value[4] * 256 + value[5]).ToString();
                    }
                }
                value = CommObj.Send(new byte[] { addr, 0x45 }, 6);
                if (value != null)
                {
                    if (value.Length == 6)
                    {
                        lbMX.Text = (value[0] * 256 + value[1]).ToString();
                        lbMY.Text = (value[2] * 256 + value[3]).ToString();
                        lbMZ.Text = (value[4] * 256 + value[5]).ToString();
                    }
                }
                value = CommObj.Send(new byte[] { addr, 0x50 }, 6);
                if (value != null)
                {
                    if (value.Length == 6)
                    {
                        lbHeading.Text = (value[0] * 256 + value[1]).ToString();
                        lbPitch.Text = (value[2] * 256 + value[3]).ToString();
                        lbRoll.Text = (value[4] * 256 + value[5]).ToString();
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
