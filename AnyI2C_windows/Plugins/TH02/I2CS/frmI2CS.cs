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
namespace TH02_I2CS
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

        private void frmI2CS_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommObj.LogText("GUI Closed");
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
                double cTemp=0;
                _ERROR.Visible = false;
                byte addr = GetAddress(false);
                byte[] value = CommObj.Send(new byte[] { addr, 0x03, 0x11 }, 0);
                Thread.Sleep(500);
                value = CommObj.Send(new byte[] { addr, 0x00 }, 3);
                if (value !=null)
                {
                    double temp = (((value[1] & 0xFF) * 256) + (value[2] & 0xFC)) / 4;
                     cTemp = (temp / 32.0) - 50.0;
                    lbT.Text = cTemp.ToString("F2");
                }
                else
                {
                    _ERROR.Visible = true;
                }

                byte[] value1 = CommObj.Send(new byte[] { addr, 0x03, 0x01 }, 0);
                Thread.Sleep(500);
                value1 = CommObj.Send(new byte[] { addr, 0x00 }, 3);
                if (value1 != null)
                {
                    double hum = ((((value1[1] & 0xFF) * 256) + (value1[2] & 0xF0)) / 16) / 16 - 24;
                    double humidity = (hum - (((hum * hum) * (-0.00393)) + (hum * 0.4008) - 4.7844));
                    humidity = humidity + (cTemp - 30) * (humidity * 0.00237 + 0.1937);
                    lbH.Text = humidity.ToString("F2");
                }
                else
                {
                    _ERROR.Visible = true;
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
