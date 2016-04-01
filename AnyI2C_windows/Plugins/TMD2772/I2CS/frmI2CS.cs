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

namespace TMD2772_I2CS
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
                // write to config
                byte[] value = CommObj.Send(new byte[] { 0x80, 0xF },0);
                value = CommObj.Send(new byte[] { 0x94}, 1);
                int c0 = value[0];
                value = CommObj.Send(new byte[] { 0x95}, 1);
                c0 = c0 + value[0] * 256;

                value = CommObj.Send(new byte[] { 0x96 }, 1);
                int c1 = value[0];
                value = CommObj.Send(new byte[] { 0x97 }, 1);
                c1 = c1 + value[0] * 256;

                value = CommObj.Send(new byte[] { 0x98 }, 1);
                int p = value[0];
                value = CommObj.Send(new byte[] { 0x99 }, 1);
                p = p + value[0] * 256;

                double cpl = 255 * 2.72 * 1 / 20;
                double lux1 = (c0 - 1.75 * c1) / cpl;
                double lux2 = (0.63 * c0 - c1) / cpl;
                double lux = Math.Max(lux1, lux2);
                if (lux < 0)
                {
                    lux = 0;
                }
                lbCh0.Text = lux.ToString("F0");
                lbProx.Text = p.ToString();
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
