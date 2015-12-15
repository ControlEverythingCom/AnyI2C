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

namespace TCS3414_I2CS
{
    public partial class frmI2CS : Form
    {
        CommInterface CommObj = null;
        public frmI2CS()
        {
            InitializeComponent();
        }

        private void frmTSL45315_Load(object sender, EventArgs e)
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
                // power on and measure
                // write to config
                byte[] value = CommObj.Send(new byte[] { addr, 0x80, 0x3 },0);
                value = CommObj.Send(new byte[] { addr, 0x90}, 1);
                int G = value[0];
                value = CommObj.Send(new byte[] { addr, 0x91 }, 1);
                G = G + value[0] * 256;
                lbG.Text = G.ToString();

                value = CommObj.Send(new byte[] { addr, 0x92 }, 1);
                int R = value[0];
                value = CommObj.Send(new byte[] { addr, 0x93 }, 1);
                R = R + value[0] * 256;
                lbR.Text = R.ToString();

                value = CommObj.Send(new byte[] { addr, 0x94 }, 1);
                int B = value[0];
                value = CommObj.Send(new byte[] { addr, 0x95 }, 1);
                B = B + value[0] * 256;
                lbB.Text = B.ToString();

                value = CommObj.Send(new byte[] { addr, 0x96 }, 1);
                int C = value[0];
                value = CommObj.Send(new byte[] { addr, 0x97 }, 1);
                C = C + value[0] * 256;
                lbC.Text = C.ToString();
                pictureBox1.BackColor = Color.FromArgb( R / 2, G / 2, B / 2);
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
