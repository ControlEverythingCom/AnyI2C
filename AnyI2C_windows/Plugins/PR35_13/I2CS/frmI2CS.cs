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

namespace PR35_13_I2CS
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
                //Power On

                byte[] value = CommObj.Send(new byte[] { addr, 0x04, 1 }, 0); // set to mode 1,

                // Read data of channel 1
                value = CommObj.Send(new byte[] { addr, 0x06 }, 6);
                if (value != null)
                {
                    int freq1 = value[0] * 256 + value[1];
                    double Period1 = (value[2] * 65536 + value[3] * 256 + value[4])/10000;
                    int dutyCycle1 = value[5];
                    lbCh0.Text = string.Format("{0}Hz {1}ms {2}%", freq1, Period1, dutyCycle1);
                }
                // Read data of channel 1
                value = CommObj.Send(new byte[] { addr, 0x13 }, 6);
                if (value != null)
                {
                    int freq1 = value[0] * 256 + value[1];
                    double Period1 = (value[2] * 65536 + value[3] * 256 + value[4]) / 10000;
                    int dutyCycle1 = value[5];
                    lbCh1.Text = string.Format("{0}Hz {1}ms {2}%", freq1, Period1, dutyCycle1);
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
