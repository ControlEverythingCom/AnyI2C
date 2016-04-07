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

namespace PCA9530_I2CS
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
                int data = 0;
                //Power On
                byte[] value = CommObj.Send(new byte[] { addr, 0xA0, 0xFF }, 0);
                Thread.Sleep(500);
                // Read data
                value = CommObj.Send(new byte[] { addr, 0x00 }, 1);
                if (value != null)
                {
                    data = (value[0] & 0x0F);
                }
                int i;
                string lbout;
                for (i = 0; i < 4; i++)
                {
                    int mask = 0;
                    mask = (int)Math.Pow(2, i);
                    if ((data & mask) == 0)
                    {
                        lbout = "LOW";
                    }
                    else
                    {
                        lbout = "HIGH";
                    }
                    if (i == 0)
                    {
                        lbCh0.Text = lbout;
                    }
                    else if (i == 1)
                    {
                        lbCh1.Text = lbout;
                    }
                    Thread.Sleep(500);
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

        private void btnReadCh0_Click(object sender, EventArgs e)
        {
            ReadSensor();
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
