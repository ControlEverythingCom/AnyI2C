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

namespace PCA9547_I2CMUX
{
    public partial class frmI2CMUX : Form
    {
        CommInterface CommObj = null;
        public frmI2CMUX()
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
                byte[] value = CommObj.Send(new byte[] { addr }, 1);
                Thread.Sleep(500);
                // Read data
                if (value != null)
                {
                    data = (value[0] & 0x07);
                }
                numChannel.Value = data;
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

        private void numChannel_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _ERROR.Visible = false;
                byte addr = GetAddress(false);
                int data = 0;
                //Power On
                byte[] value = CommObj.Send(new byte[] { addr,(byte)numChannel.Value }, 0);

            }
            catch
            {
                _ERROR.Visible = true;
            }

        }
    }

    public class MyGUI : GuiInterface
    {
        public void Show(CommInterface com)
        {
            frmI2CMUX frm = new frmI2CMUX();
            frm.Attach(com);
            frm.ShowDialog();
        }
    }
}
