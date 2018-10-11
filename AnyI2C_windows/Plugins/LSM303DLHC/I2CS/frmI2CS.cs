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

namespace LSM303DLHC_I2CS
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

        private string ReadAcceleration()
        {
            try
            {
                _ERROR.Visible = false;
                byte addr = GetAddress(false);
                //Cofigure Sensor
                byte[] value = CommObj.Send(new byte[] { addr, 0x20, 0x27 }, 0);
                value = CommObj.Send(new byte[] { addr, 0x23, 0x00 }, 0);
                Thread.Sleep(500);
                byte[] valuexl = CommObj.Send(new byte[] { addr, 0x28 }, 1);
                byte[] valuexh = CommObj.Send(new byte[] { addr, 0x29 }, 1);
                byte[] valueyl = CommObj.Send(new byte[] { addr, 0x2A }, 1);
                byte[] valueyh = CommObj.Send(new byte[] { addr, 0x2B }, 1);
                byte[] valuezl = CommObj.Send(new byte[] { addr, 0x2C }, 1);
                byte[] valuezh = CommObj.Send(new byte[] { addr, 0x2D }, 1);
                if (valuexh != null && valuexl != null && valueyh != null && valueyl != null && valuezh != null && valuezl != null)
                {
                    lbAX.Text = ((valuexh[0] * 256 + valuexl[0]) > 32767) ? (((valuexh[0] * 256 + valuexl[0]) - 65536).ToString()) : ((valuexh[0] * 256 + valuexl[0]).ToString());
                    lbAY.Text = ((valueyh[0] * 256 + valueyl[0]) > 32767) ? (((valueyh[0] * 256 + valueyl[0]) - 65536).ToString()) : ((valueyh[0] * 256 + valueyl[0]).ToString());
                    lbAZ.Text = ((valuezh[0] * 256 + valuezl[0]) > 32767) ? (((valuezh[0] * 256 + valuezl[0]) - 65536).ToString()) : ((valuezh[0] * 256 + valuezl[0]).ToString());
                }
                return "OK";
            }
            catch
            {
                _ERROR.Visible = true;
            }

            return "Error";
        }

        private string ReadMagnet()
        {
            try
            {
                _ERROR.Visible = false;
                byte addr = GetAddress(false);
                //Cofigure Sensor
                byte[] value = CommObj.Send(new byte[] { addr, 0x00, 0x10 }, 0);
                value = CommObj.Send(new byte[] { addr, 0x01, 0x20 }, 0);
                value = CommObj.Send(new byte[] { addr, 0x02, 0x00 }, 0);
                Thread.Sleep(500);
                byte[] valuexl = CommObj.Send(new byte[] { addr, 0x04 }, 1);
                byte[] valuexh = CommObj.Send(new byte[] { addr, 0x03 }, 1);
                byte[] valueyl = CommObj.Send(new byte[] { addr, 0x08 }, 1);
                byte[] valueyh = CommObj.Send(new byte[] { addr, 0x07 }, 1);
                byte[] valuezl = CommObj.Send(new byte[] { addr, 0x06 }, 1);
                byte[] valuezh = CommObj.Send(new byte[] { addr, 0x05 }, 1);
                if (valuexh != null && valuexl != null && valueyh != null && valueyl != null && valuezh != null && valuezl != null)
                {
                    lbMX.Text = ((valuexh[0] * 256 + valuexl[0]) > 32767) ? (((valuexh[0] * 256 + valuexl[0]) - 65536).ToString()) : ((valuexh[0] * 256 + valuexl[0]).ToString());
                    lbMY.Text = ((valueyh[0] * 256 + valueyl[0]) > 32767) ? (((valueyh[0] * 256 + valueyl[0]) - 65536).ToString()) : ((valueyh[0] * 256 + valueyl[0]).ToString());
                    lbMZ.Text = ((valuezh[0] * 256 + valuezl[0]) > 32767) ? (((valuezh[0] * 256 + valuezl[0]) - 65536).ToString()) : ((valuezh[0] * 256 + valuezl[0]).ToString());
                }
                return "OK";
            }
            catch
            {
                _ERROR.Visible = true;
            }

            return "Error";
        }

        private void frmI2CS_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            CommObj.LogText("GUI Closed");
        }

        private void numPort_ValueChanged(object sender, EventArgs e)
        {
            CommObj.SetPort((byte)numPort.Value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ReadAcceleration();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ReadMagnet();
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

        private void chkAutoUpdateMag_CheckedChanged(object sender, EventArgs e)
        {
            btnReadCh1.Enabled = !chkAutoUpdateMag.Checked;
            if (chkAutoUpdateMag.Checked)
            {
                timer2.Enabled = true;
            }
            else
            {
                timer2.Enabled = false;
            }
        }

        private void btnReadCh0_Click(object sender, EventArgs e)
        {
            ReadAcceleration();
        }

        private void btnReadCh1_Click(object sender, EventArgs e)
        {
            ReadMagnet();
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
