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

namespace MS5803_07BA_I2CS
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
            return (byte)(numAddress.Value);
        }

        private string ReadSensor()
        {
            try
            {
                _ERROR.Visible = false;
                byte addr = GetAddress(false);
                // reset sensor
                byte[] value = CommObj.Send(new byte[] { addr, 0x1E }, 0);
                Thread.Sleep(1000);
                double d1 = 0;
                double d2 = 0;
                double SensT1 = 0;
                double OffT1 = 0;
                double TSC = 0;
                double TCO = 0;
                double Tref = 0;
                double TempSens = 0;
                double T2 = 0;
                double OFF2 = 0;
                double SENS2 = 0;
                // convert d1
                value = CommObj.Send(new byte[] { addr, 0x40 }, 0);
                Thread.Sleep(1000);
                value = CommObj.Send(new byte[] { addr, 0x00 }, 3);
                if (value != null)
                {
                    if (value.Length == 3)
                    {
                        d1 = value[0] * 256 * 256 + value[1] * 256 + value[2];
                    }
                }
                //d1 = 9085466;
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
                //d2 = 8569150;
                // Read Pressure sensitivity
                value = CommObj.Send(new byte[] { addr, 0xA2 }, 2);
                if (value != null)
                {
                    if (value.Length == 2)
                    {
                        SensT1 = value[0] * 256 + value[1];
                    }
                }
                // Read Pressure offset
                value = CommObj.Send(new byte[] { addr, 0xA4 }, 2);
                if (value != null)
                {
                    if (value.Length == 2)
                    {
                        OffT1 = value[0] * 256 + value[1];
                    }
                }
                // Read Temperature coefficient of pressure sensitivity
                value = CommObj.Send(new byte[] { addr, 0xA6 }, 2);
                if (value != null)
                {
                    if (value.Length == 2)
                    {
                        TSC = value[0] * 256 + value[1];
                    }
                }
                // Temperature coefficient of pressure offset 
                value = CommObj.Send(new byte[] { addr, 0xA8 }, 2);
                if (value != null)
                {
                    if (value.Length == 2)
                    {
                        TCO = value[0] * 256 + value[1];
                    }
                }
                // Reference temperature
                value = CommObj.Send(new byte[] { addr, 0xAA }, 2);
                if (value != null)
                {
                    if (value.Length == 2)
                    {
                        Tref = value[0] * 256 + value[1];
                    }
                }
                // Temperature coefficient of the temperature
                value = CommObj.Send(new byte[] { addr, 0xAC }, 2);
                if (value != null)
                {
                    if (value.Length == 2)
                    {
                        TempSens = value[0] * 256 + value[1];
                    }
                }
                double dT = d2 - Tref * 256;
                double tt = Math.Pow(2, 23);
                double TEMP = 2000.0 + dT * TempSens / tt;
                double OFF = OffT1 * Math.Pow(2, 18) + (TCO * dT) / 32.0;
                double SENS = SensT1 * Math.Pow(2, 17) + (TSC * dT) / 64.0;
                if (TEMP > 2000)
                {
                    T2 = 0;
                    OFF2 = 0;
                    SENS2 = 0;
                }
                else if (TEMP <= 2000)
                {
                    T2 = 3 * dT * dT / Math.Pow(2, 33);
                    OFF2 = 3 * (TEMP - 2000) * (TEMP - 2000) / 8;
                    SENS2 = 7 * (TEMP - 2000) * (TEMP - 2000) / 8;
                    if (TEMP < -1500)
                    {
                        SENS2 = SENS2 + 3 * (TEMP + 1500) * (TEMP + 1500);
                    }
                }
                TEMP = TEMP - T2;
                OFF = OFF - OFF2;
                SENS = SENS - SENS2;
                double P = (d1 * SENS / Math.Pow(2, 21) - OFF) / Math.Pow(2, 15) * 0.01;
                lbP.Text = P.ToString("F2");
                lbT.Text = (TEMP / 100.0).ToString("F2");
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
