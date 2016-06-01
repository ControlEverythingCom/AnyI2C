using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AnyI2C;


namespace MQ9_I2CADC
{
    
    public partial class I2CADC : Form
    {
        CommInterface CommObj = null;
        public I2CADC()
        {
            InitializeComponent();
        }

        private void I2CADC_Load(object sender, EventArgs e)
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

        private string ReadCh()
        {
            try
            {
                _ERROR.Visible = false;
                byte addr = GetAddress(false);
                byte[] value = CommObj.Send(new byte[] { addr, 0x00 }, 2);
                if (value != null)
                {
                    double raw_adc = (((value[0] & 0x0F) * 256) + (value[1] & 0xFF));
                    double ppm = ((1000.0 / 4096.0) * raw_adc) + 10;
                    return ppm.ToString("F2");
                }
                else
                {
                    _ERROR.Visible = true;
                    return "Error";
                }
            }
            catch
            {
                _ERROR.Visible = true;
                return "Error";
            }
        }
        private void I2CADC_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            CommObj.LogText("GUI Closed");
        }

        private void btnReadCh0_Click(object sender, EventArgs e)
        {
            lbCh0.Text = ReadCh();
        }

        private void numPort_ValueChanged(object sender, EventArgs e)
        {
            CommObj.SetPort((byte)numPort.Value);
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
            lbCh0.Text = ReadCh();
        }
    }

    public class MyGUI : GuiInterface
    {
        public void Show(CommInterface com)
        {
            I2CADC frm = new I2CADC();
            frm.Attach(com);
            frm.ShowDialog();
        }
    }
}
