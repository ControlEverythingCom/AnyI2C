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

namespace TMG39931_I2CS
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
                //RGBC time
                byte[] value = CommObj.Send(new byte[] { addr, 0x80, 0x0F }, 0);

                value = CommObj.Send(new byte[] { addr, 0x81, 0xFF }, 0);
                //Wait time
                value = CommObj.Send(new byte[] { addr, 0x83, 0xFF }, 0);
                //Gain control registers
                value = CommObj.Send(new byte[] { addr, 0x8F, 0x00 }, 0);
                // Enable Register
                // power on and measure
                value = CommObj.Send(new byte[] { addr, 0x80, 0x0F }, 0);

                double c = value[0];
                value = CommObj.Send(new byte[] { addr, 0x95 }, 1);
                c = value[0] * 256 + c;

                value = CommObj.Send(new byte[] { addr, 0x96 }, 1);
                double R = value[0];
                value = CommObj.Send(new byte[] { addr, 0x97 }, 1);
                R = value[0] * 256 + R;

                value = CommObj.Send(new byte[] { addr, 0x98 }, 1);
                double G = value[0];
                value = CommObj.Send(new byte[] { addr, 0x99 }, 1);
                G = value[0] * 256 + G;

                value = CommObj.Send(new byte[] { addr, 0x9A }, 1);
                double B = value[0];
                value = CommObj.Send(new byte[] { addr, 0x9B }, 1);
                B = value[0] * 256 + B;

                value = CommObj.Send(new byte[] { addr, 0x9C }, 1);
                double P = value[0];

                lbC.Text = c.ToString("F0");
                lbR.Text = R.ToString("F0");
                lbG.Text = G.ToString("F0");
                lbB.Text = B.ToString("F0");
                lbP.Text = P.ToString("F0");
                return value[0].ToString();
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
