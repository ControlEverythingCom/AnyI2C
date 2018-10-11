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

namespace STTS751_I2CS
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
                byte[] value = CommObj.Send(new byte[] { addr, 0x03, 0x8C }, 0);
                value = CommObj.Send(new byte[] { addr, 0x04, 0x04 }, 0);
                byte[] value2 = CommObj.Send(new byte[] { addr, 0x02 }, 1);
                byte[] value1 = CommObj.Send(new byte[] { addr, 0x00 }, 1);
                if (value1 != null && value2 != null)
                {
                    int temp = (((value1[0] & 0xFF) * 256) + (value2[0] & 0xF0)) / 16;
                    if (temp > 2047)
                    {
                        temp -= 4096;
                    }
                    double cTemp = temp * 0.0625;
                    lbCh0.Text = cTemp.ToString("F2");
                    return cTemp.ToString();
                }
            }
            catch
            {
                _ERROR.Visible = true;
            }

            return "Error";
        }

        private void frmI2CS_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommObj.LogText("GUI Closed");
        }

        private void numPort_ValueChanged(object sender, EventArgs e)
        {
            CommObj.SetPort((byte)numPort.Value);
        }

        private void btnReadCh0_Click(object sender, EventArgs e)
        {
            ReadSensor();
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
