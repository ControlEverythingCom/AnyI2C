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

namespace MPU6000_I2CS
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
            return (byte)(numAddress.Value);
        }

        private string ReadSensor()
        {
            try
            {
                _ERROR.Visible = false;
                byte addr = GetAddress(false);
                //config the sensor
                CommObj.Send(new byte[] { addr, 0x6B, 0 }, 0);
                Thread.Sleep(500);
                byte[] valuexh = CommObj.Send(new byte[] { addr, 0x43 }, 1);
                byte[] valuexl = CommObj.Send(new byte[] { addr, 0x44 }, 1);
                byte[] valueyh = CommObj.Send(new byte[] { addr, 0x45 }, 1);
                byte[] valueyl = CommObj.Send(new byte[] { addr, 0x46 }, 1);
                byte[] valuezh = CommObj.Send(new byte[] { addr, 0x47 }, 1);
                byte[] valuezl = CommObj.Send(new byte[] { addr, 0x48 }, 1);
                if (valuexh != null && valuexl != null && valueyh != null && valueyl != null && valuezh != null && valuezl != null)
                {
                    lbX.Text = ((valuexh[0] * 256 + valuexl[0]) > 32767) ? ((((valuexh[0] * 256 + valuexl[0]) - 65536) / 16).ToString()) : (((valuexh[0] * 256 + valuexl[0]) / 16).ToString());
                    lbY.Text = ((valueyh[0] * 256 + valueyl[0]) > 32767) ? ((((valueyh[0] * 256 + valueyl[0]) - 65536) / 16).ToString()) : (((valueyh[0] * 256 + valueyl[0]) / 16).ToString());
                    lbZ.Text = ((valuezh[0] * 256 + valuezl[0]) > 32767) ? ((((valuezh[0] * 256 + valuezl[0]) - 65536) / 16).ToString()) : (((valuezh[0] * 256 + valuezl[0]) / 16).ToString());
                }
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
