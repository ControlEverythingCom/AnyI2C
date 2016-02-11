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

namespace BH1745NUC_I2CS
{
    public partial class frmI2CS : Form
    {
        CommInterface CommObj = null;
        public frmI2CS()
        {
            InitializeComponent();
        }

        private void frmBH1745NUC_Load(object sender, EventArgs e)
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
                // Congire Function Settings
                byte[] value = CommObj.Send(new byte[] { addr, 0x41, 0x00 }, 0);
                Thread.Sleep(500);
                value = CommObj.Send(new byte[] { addr, 0x42, 0x10 }, 0);
                value = CommObj.Send(new byte[] { addr, 0x44, 0x02 }, 0);
                value = CommObj.Send(new byte[] { addr, 0x50 }, 8);
                if (value != null)
                {

                    int r = value[1] * 256 + value[0];
                    int g = value[3] * 256 + value[2];
                    int b = value[5] * 256 + value[4];
                    int c = value[7] * 256 + value[6];
                    lbCh1.Text = r.ToString("F0");
                    lbCh2.Text = g.ToString("F0");
                    lbCh3.Text = b.ToString("F0");
                    lbCh0.Text = c.ToString("F0");
                    return value[0].ToString();
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

        private void label1_Click(object sender, EventArgs e)
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
