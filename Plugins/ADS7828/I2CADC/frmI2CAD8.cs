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

namespace ADS7828_I2CAD8
{
    public partial class frmI2CAD8 : Form
    {
        CommInterface CommObj = null;
        public frmI2CAD8()
        {
            InitializeComponent();
        }

        private void Setup_PCA9685_Click(object sender, EventArgs e)
        {

        }

        private void frmADS7828_Load(object sender, EventArgs e)
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
    }


    public class MyGUI : GuiInterface
    {
        public void Show(CommInterface com)
        {
            frmI2CAD8 frm = new frmI2CAD8();
            frm.Attach(com);
            frm.ShowDialog();
        }
    }

}
