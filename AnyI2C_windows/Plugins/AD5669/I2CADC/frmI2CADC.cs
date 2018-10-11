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

namespace ADS7828_I2CADC
{
    public partial class frmI2CADC : Form
    {
        CommInterface CommObj = null;
        public frmI2CADC()
        {
            InitializeComponent();
        }

        private void Setup_PCA9685_Click(object sender, EventArgs e)
        {

        }

        private void frmADS7828_Load(object sender, EventArgs e)
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

        private string ReadCh(byte ch)
        {
            try
            {
                _ERROR.Visible = false;
                byte addr = GetAddress(false);
                byte[] value = CommObj.Send(new byte[] { addr, ch}, 2);
                if (value != null)
                {
                    return (value[0] * 256 + value[1]).ToString();
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
            lbCh0.Text = ReadCh(128);
        }

        private void btnReadCh1_Click(object sender, EventArgs e)
        {
            lbCh1.Text = ReadCh(192);
        }

        private void btnReadCh2_Click(object sender, EventArgs e)
        {
            lbCh2.Text = ReadCh(144);
        }

        private void btnReadCh3_Click(object sender, EventArgs e)
        {
            lbCh3.Text = ReadCh(208);
        }

        private void btnReadCh4_Click(object sender, EventArgs e)
        {
            lbCh4.Text = ReadCh(160);
        }

        private void btnReadCh5_Click(object sender, EventArgs e)
        {
            lbCh5.Text = ReadCh(224);
        }

        private void btnReadCh6_Click(object sender, EventArgs e)
        {
            lbCh6.Text = ReadCh(176);
        }

        private void btnReadCh7_Click(object sender, EventArgs e)
        {
            lbCh7.Text = ReadCh(240);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbCh0.Text = ReadCh(128);
            lbCh1.Text = ReadCh(192);
            lbCh2.Text = ReadCh(144);
            lbCh3.Text = ReadCh(208);
            lbCh4.Text = ReadCh(160);
            lbCh5.Text = ReadCh(224);
            lbCh6.Text = ReadCh(176);
            lbCh7.Text = ReadCh(240);
        }

        private void chkAutoUpdate_CheckedChanged(object sender, EventArgs e)
        {
            btnReadCh0.Enabled = !chkAutoUpdate.Checked;
            btnReadCh1.Enabled = !chkAutoUpdate.Checked;
            btnReadCh2.Enabled = !chkAutoUpdate.Checked;
            btnReadCh3.Enabled = !chkAutoUpdate.Checked;
            btnReadCh4.Enabled = !chkAutoUpdate.Checked;
            btnReadCh5.Enabled = !chkAutoUpdate.Checked;
            btnReadCh6.Enabled = !chkAutoUpdate.Checked;
            btnReadCh7.Enabled = !chkAutoUpdate.Checked;
            if (chkAutoUpdate.Checked)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void frmI2CADC_FormClosing(object sender, FormClosingEventArgs e)
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
            frmI2CADC frm = new frmI2CADC();
            frm.Attach(com);
            frm.ShowDialog();
        }
    }

}
