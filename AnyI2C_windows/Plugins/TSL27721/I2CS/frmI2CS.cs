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

namespace TSL27721_I2CS
{
    public partial class frmI2CS : Form
    {
        CommInterface CommObj = null;
        public frmI2CS()
        {
            InitializeComponent();
        }

        private void frmTSL27721_Load(object sender, EventArgs e)
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
                // write to config
                // power on
                byte[] value = CommObj.Send(new byte[] { addr, 0x80, 0x0F }, 0);
                // Set ALS Timing
                value = CommObj.Send(new byte[] { addr, 0x81, 0x00 }, 0);
                //Set Proximity Timing
                value = CommObj.Send(new byte[] { addr, 0x82, 0xFF }, 0);
                // Set Wait Timing
                value = CommObj.Send(new byte[] { addr, 0x83, 0xFF }, 0);
                // Set Control Settings
                value = CommObj.Send(new byte[] { addr, 0x8F, 0x20 }, 0);
                // Measure data, Luminance first, Proximity second
                value = CommObj.Send(new byte[] { addr, 0x94 }, 6);

                if (value != null)
                {
                    int c0 = value[1] * 256 + value[0];
                    int c1 = value[3] * 256 + value[2];
                    int p = value[5] * 256 + value[4];
                    double cpl = 255 / 60;
                    double lux1 = (c0 - 1.87 * c1) / cpl;
                    double lux2 = (0.63 * c0 - c1) / cpl;
                    double lux = Math.Max(lux1, lux2);
                    if (lux < 0)
                    {
                        lux = 0;
                    }
                    lbCh1.Text = p.ToString("F0");
                    lbCh0.Text = lux.ToString("F0");
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
