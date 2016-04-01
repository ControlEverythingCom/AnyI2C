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

namespace ADC081C_I2CADC
{
    public partial class frmI2CADC : Form
    {
        CommInterface CommObj = null;
        public frmI2CADC()
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
            if (Read)
            {
                return (byte)(numAddress.Value * 2 + 1);
            }
            return (byte)(numAddress.Value * 2);
        }

        private string ReadCh(byte ch)
        {
            try
            {
                _ERROR.Visible = false;
                byte addr = GetAddress(false);
                byte[] value = CommObj.Send(new byte[] { addr, ch}, 2);
                if (value != null)
                {
                    byte v = (byte)((value[0] & 0xf)<<4);
                    byte v1 = (byte)(value[1] >> 4);
                    return (v + v1).ToString();

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
            lbCh0.Text = ReadCh(0);
        }

        private void numPort_ValueChanged(object sender, EventArgs e)
        {
            CommObj.SetPort((byte)numPort.Value);
        }

        private void frmADC081C_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommObj.LogText("GUI Closed");
        }

    }


    public class MyGUI : GuiInterface
    {
        public void Show(CommInterface com)
        {
            frmI2CADC frm = new frmI2CADC();
            frm.Attach(com);
            frm.ShowDialog();
        }
    }

}
