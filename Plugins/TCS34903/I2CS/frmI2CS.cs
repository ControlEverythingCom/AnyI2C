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

namespace TCS34903_I2CS
{
    public partial class frmI2CS : Form
    {
        CommInterface CommObj = null;
        public frmI2CS()
        {
            InitializeComponent();
        }

        private void frmTCS34903_Load(object sender, EventArgs e)
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
                // Power On, ADC Enable
                byte[] value = CommObj.Send(new byte[] { addr, 0x80, 0x0B }, 0);
                // Configure Integration Time
                value = CommObj.Send(new byte[] { addr, 0x81, 0x00 }, 0);
                // Configure Wait Time
                value = CommObj.Send(new byte[] { addr, 0x83, 0xFF }, 0);
                // Control Gain
                value = CommObj.Send(new byte[] { addr, 0x8F, 0x00 }, 0);
                // Configure IR Channel
                value = CommObj.Send(new byte[] { addr, 0xB0, 0x80 }, 0);
                value = CommObj.Send(new byte[] { addr, 0x94 }, 8);
                if (value != null)
                {
                    int i = value[1] * 256 + value[0];
                    int r = value[3] * 256 + value[2];
                    int g = value[5] * 256 + value[4];
                    int b = value[7] * 256 + value[6];
                    lbCh0.Text = i.ToString("F0");
                    lbCh1.Text = r.ToString("F0");
                    lbCh2.Text = g.ToString("F0");
                    lbCh3.Text = b.ToString("F0");
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
