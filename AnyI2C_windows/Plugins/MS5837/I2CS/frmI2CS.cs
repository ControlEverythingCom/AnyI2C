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

namespace MS5837_I2CS
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
                // reset sensor
                byte[] value = CommObj.Send(new byte[] { addr, 0x1E}, 0);
                Thread.Sleep(1000);
                double SensT1 = 34982;
                double OffT1 = 36352;
                double TSC = 20328;
                double TCO = 22354;
                double Tref = 26646;
                double TempSens = 26146;
                double d1 = 0;
                double d2 = 0;
                // convert d1
                value = CommObj.Send(new byte[] { addr, 0x40 }, 0);
                Thread.Sleep(100);
                value = CommObj.Send(new byte[] { addr, 0x00 }, 3);
                if (value != null)
                {
                    if (value.Length == 3)
                    {
                        d1 = value[0] * 256 * 256 + value[1] * 256 + value[2];
                    }
                }
                //d1 = 4958179;
                // convert d2
                value = CommObj.Send(new byte[] { addr, 0x50 }, 0);
                Thread.Sleep(100);
                value = CommObj.Send(new byte[] { addr, 0x00 }, 3);
                if (value != null)
                {
                    if (value.Length == 3)
                    {
                        d2 = value[0] * 256 * 256 + value[1] * 256 + value[2];
                    }
                }
                //d2 = 6815414;
                // this is demo, please refer the spec for accurate cal
                double dT = d2 - Tref * 256;
                double tt = Math.Pow(2, 23);
                double TEMP = 2000.0 + dT * TempSens /tt;
                double OFF = OffT1 * Math.Pow (2 ,16) + (TCO * dT) / 128.0;
                double SENS = SensT1 * Math.Pow(2,15)+ (TSC * dT) / 256.0;
                double P = (d1 * SENS / Math.Pow(2,21) - OFF) / Math.Pow(2 , 13) *0.1;
                lbP.Text = P.ToString("F2") ;
                lbT.Text = (TEMP / 100.0).ToString("F2");
                return P.ToString("F2");

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

        private void frmI2CS_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommObj.LogText("GUI Closed");
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
