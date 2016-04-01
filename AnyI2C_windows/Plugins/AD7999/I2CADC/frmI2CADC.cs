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

namespace AD7999_I2CADC
{
    public partial class frmI2CADC : Form
    {
        CommInterface CommObj = null;
        public frmI2CADC()
        {
            InitializeComponent();
        }

        private void frmAD7999_Load(object sender, EventArgs e)
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
                byte[] value = CommObj.Send(new byte[] { addr, ch}, 2);
                if (value != null)
                {
                    byte v = (byte)(value[0] & 0x0F);
                    int v1 = (v * 256 + value[1]) / 16;
                    return v1.ToString();
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
            lbCh0.Text = ReadCh(16);
        }

        private void btnReadCh1_Click(object sender, EventArgs e)
        {
            lbCh1.Text = ReadCh(32);
        }

        private void btnReadCh2_Click(object sender, EventArgs e)
        {
            lbCh2.Text = ReadCh(64);
        }

        private void btnReadCh3_Click(object sender, EventArgs e)
        {
            lbCh3.Text = ReadCh(128);
        }

        private void frmAD7999_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            CommObj.LogText("GUI Closed");
        }

        private void numPort_ValueChanged(object sender, EventArgs e)
        {
            CommObj.SetPort((byte)numPort.Value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbCh0.Text = ReadCh(16);
            lbCh1.Text = ReadCh(32);
            lbCh2.Text = ReadCh(64);
            lbCh3.Text = ReadCh(128);
        }

        private void chkAutoUpdate_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = chkAutoUpdate.Checked;
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
