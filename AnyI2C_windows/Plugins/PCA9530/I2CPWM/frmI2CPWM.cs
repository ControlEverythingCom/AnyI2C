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

namespace PCA9530_I2CPWM
{
    public partial class frmI2CPWM : Form
    {
        CommInterface CommObj = null;
        public frmI2CPWM()
        {
            InitializeComponent();
        }

        private void frmI2CS_Load(object sender, EventArgs e)
        {
            CommObj.LogText("GUI Opened");
            numAddress.Value = CommObj.GetDefaultAddress();
            numPort.Value = CommObj.GetPort();
            cmbLed0.SelectedIndex = 0;
            cmbLed1.SelectedIndex = 0;
            
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
                //Select frequency prescaler
                //0x4B(75)	Period of blink = 0.5 sec
                byte[] value = CommObj.Send(new byte[] { addr, 0x01, 0x4B }, 0);
                //Select pulse width modulation
                value = CommObj.Send(new byte[] { addr, 0x02, 0x80 }, 0);
                //Select LED selector register
                value = CommObj.Send(new byte[] { addr, 0x05, 0xFA }, 1);

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

        private void hScrollBarPCS0_Scroll(object sender, ScrollEventArgs e)
        {
            byte value = (byte)hScrollBarPCS0.Value;
            lbPCS0.Text = value.ToString();
            byte addr = GetAddress(false);
            // write to pcs0 register
            CommObj.Send(new byte[] { addr, 0x1, value }, 0);
        }

        private void hScrollBarPWM0_Scroll(object sender, ScrollEventArgs e)
        {
            byte value = (byte)hScrollBarPWM0.Value;
            lbPWM0.Text = value.ToString();
            byte addr = GetAddress(false);
            // write to pwm0 register
            CommObj.Send(new byte[] { addr, 0x2, value }, 0);
        }


        private void hScrollBarPCS1_Scroll(object sender, ScrollEventArgs e)
        {
            byte value = (byte)hScrollBarPCS1.Value;
            lbPCS1.Text = value.ToString();
            byte addr = GetAddress(false);
            // write to pcs1 register
            CommObj.Send(new byte[] { addr, 0x3, value }, 0);
        }

        private void hScrollBarPWM1_Scroll(object sender, ScrollEventArgs e)
        {
            byte value = (byte)hScrollBarPWM1.Value;
            lbPWM1.Text = value.ToString();
            byte addr = GetAddress(false);
            // write to pwm2 register
            CommObj.Send(new byte[] { addr, 0x4, value }, 0);
        }

        private void cmbLed0_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte value = (byte)(cmbLed0.SelectedIndex + cmbLed1.SelectedIndex * 4);
            byte addr = GetAddress(false);
            // write to LED Selector register
            CommObj.Send(new byte[] { addr, 0x5, value }, 0);
        }

    }

    public class MyGUI : GuiInterface
    {
        public void Show(CommInterface com)
        {
            frmI2CPWM frm = new frmI2CPWM();
            frm.Attach(com);
            frm.ShowDialog();
        }
    }
}
