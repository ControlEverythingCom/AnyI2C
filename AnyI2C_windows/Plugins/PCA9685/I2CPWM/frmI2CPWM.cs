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

namespace PCA9685_I2CPWM
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
            cmbLed.SelectedIndex = 0;
            SetPWMFreq(scrollbarFreq.Value);
            lbFreq.Text = scrollbarFreq.Value.ToString();
        }


        public void Attach(CommInterface com)
        {
            CommObj = com;
        }


        private void SetPWMFreq(int freq)
        {
            byte addr = GetAddress(false);
            CommObj.Send(new byte[] { addr, 0x0, 0x10 }, 0); // enter sleep mode
            int prescale = 25000000 / 4096 / freq - 1;
            CommObj.Send(new byte[] { addr, 0xfe, (byte)(prescale) }, 0);
            CommObj.Send(new byte[] { addr, 0x0, 0x80 }, 0);  // resart
            CommObj.Send(new byte[] { addr, 0x1, 4 }, 0); // totem pole
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


        private void frmI2CS_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommObj.LogText("GUI Closed");
        }


        private void numPort_ValueChanged(object sender, EventArgs e)
        {
            CommObj.SetPort((byte)numPort.Value);
        }

        private void hScrollBarPCS0_Scroll(object sender, ScrollEventArgs e)
        {
            SetPWMFreq(scrollbarFreq.Value);
            lbFreq.Text = scrollbarFreq.Value.ToString();
        }

        private void scrollbarOn_Scroll(object sender, ScrollEventArgs e)
        {
            lbOn.Text = scrollbarOn.Value.ToString();
            SetupLED();
        }

        private void scrollBarOff_Scroll(object sender, ScrollEventArgs e)
        {
            lbOff.Text = scrollBarOff.Value.ToString();
            SetupLED();
        }

        private void cmbLed_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetupLED();
        }

        private void SetupLED()
        {
            int on = scrollbarOn.Value;
            int off = scrollBarOff.Value;
            int led = cmbLed.SelectedIndex;

            byte OnL = (byte)(on & 0xff);
            byte OnH = (byte)(on >> 8);
            byte OffL = (byte)(off & 0xff);
            byte OffH = (byte)(off >> 8);
            byte addr = GetAddress(false);
            if (led < 15)   // single led
            {
                CommObj.Send(new byte[] { addr, (byte)(6 + 4 * led), OnL }, 0);
                CommObj.Send(new byte[] { addr, (byte)(7 + 4 * led), OnH }, 0);
                CommObj.Send(new byte[] { addr, (byte)(8 + 4 * led), OffL }, 0);
                CommObj.Send(new byte[] { addr, (byte)(9 + 4 * led), OffH }, 0);
            }
            else // all led
            {
                CommObj.Send(new byte[] { addr, 250, OnL }, 0);
                CommObj.Send(new byte[] { addr, 251, OnH }, 0);
                CommObj.Send(new byte[] { addr, 252, OffL }, 0);
                CommObj.Send(new byte[] { addr, 253, OffH }, 0);

            }


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
