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

namespace MPL115A2_I2CS
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
                CommObj.Send(new byte[] {addr, 0x12, 0x0}, 0); // wake up device
                addr = GetAddress(true);
                Thread.Sleep(100);
                byte[] value = CommObj.Send(new byte[] {addr, 0x0}, 4);
                if (value != null)
                {
                    int p = value[1] * 4  + value[0] / 64;
                    double P1 = p * 0.25;
                    double t = (value[3] * 4 + value[2] / 64);
                    lbT.Text = (t/10).ToString("F2");

                    double a0 = 2009.75;
                    double b1 = -2.37585;
                    double b2 = -0.92047;
                    double c12 = 0.000790;

                    double Pcomp = a0 + (b1 + c12 * t) * p + b2 * t;
                    P1 = Pcomp * (115 - 50) / 1023 + 50;
                    lbP.Text = P1.ToString("F2");

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            ReadSensor();
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
