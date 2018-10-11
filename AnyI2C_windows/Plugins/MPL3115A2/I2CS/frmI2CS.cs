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

namespace MPL3115A2_I2CS
{
    public partial class frmI2CS : Form
    {
        CommInterface CommObj = null;
        public frmI2CS()
        {
            InitializeComponent();
        }

        private void frmADC081C_Load(object sender, EventArgs e)
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

        private string ReadSensor()
        {
            try
            {
                _ERROR.Visible = false;
                byte addr = GetAddress(false);
                // Configure Sensor
                byte[] value = CommObj.Send(new byte[] { addr, 0x26, 0xB8}, 0);
                Thread.Sleep(100);
                value = CommObj.Send(new byte[] { addr, 0x13, 0x07 }, 0);
                Thread.Sleep(100);
                value = CommObj.Send(new byte[] { addr, 0x26, 0xB9 }, 0);
                Thread.Sleep(500);
                value = CommObj.Send(new byte[] { addr, 0x00 }, 6);
                if (value != null)
                {
                    if (value.Length == 6)
                    {
                        if ((value[0] & 4) >0)
                        {
                            int p = value[1] * 256 * 16 + value[2] * 16 + value[3] / 16;
                            double P1 = p * 0.25;
                            lbP.Text = P1.ToString("F2");
                            double t = (value[4] * 16 + value[5] / 16)/16;
                            lbT.Text = t.ToString("F2");
                        }
                    }
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
