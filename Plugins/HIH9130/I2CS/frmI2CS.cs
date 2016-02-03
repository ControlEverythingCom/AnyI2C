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

namespace HIH9130_I2CS
{
    public partial class frmI2CS : Form
    {
        CommInterface CommObj = null;
        public frmI2CS()
        {
            InitializeComponent();
        }

        private void frmADC081C_Load(object sender, EventArgs e)
        {
            numAddress.Value = CommObj.GetDefaultAddress();
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
                byte[] value = CommObj.Send(new byte[] { addr}, 4);
                if (value != null)
                {
                    double h = ((value[0] & 0x3F) * 256 + value[1]) / 163.84;
                    double t = (value[2] * 64 + value[3] / 4) / 99.29 - 40;
                    lbHum.Text = h.ToString("F2");
                    lbCh0.Text = t.ToString("F2");
                    return value[0].ToString();
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
            ReadSensor();
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            byte addr = GetAddress(false);
            CommObj.Send(new byte[] { addr, 160, 0, 0 }, 4);
            Thread.Sleep(100);
            CommObj.Send(new byte[] { addr, 160, 63, 255 }, 4);
            Thread.Sleep(100);
            CommObj.Send(new byte[] { addr, 128, 0, 0}, 4);
            Thread.Sleep(100);
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
