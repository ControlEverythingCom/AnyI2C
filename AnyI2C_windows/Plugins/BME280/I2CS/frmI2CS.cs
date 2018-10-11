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

namespace BME280_I2CS
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
                double dig_T1 = 0;
                double dig_T2 = 0;
                double dig_T3 = 0;
                double dig_P1 = 0;
                double dig_P2 = 0;
                double dig_P3 = 0;
                double dig_P4 = 0;
                double dig_P5 = 0;
                double dig_P6 = 0;
                double dig_P7 = 0;
                double dig_P8 = 0;
                double dig_P9 = 0;
                double dig_H2 = 0;
                double dig_H3 = 0;
                double dig_H4 = 0;
                double dig_H5 = 0;
                double dig_H6 = 0;
                double adc_p = 0;
                double adc_t = 0;
                double adc_h = 0;
                //Read Temp and Pressure coefficents
                byte[] TPcoeff = CommObj.Send(new byte[] { addr, 0x88 }, 24);
                if (TPcoeff != null)
                {
                    if (TPcoeff.Length == 24)
                    {
                        //Temp coefficents
                        dig_T1 = TPcoeff[1] * 256 + TPcoeff[0];
                        dig_T2 = TPcoeff[3] * 256 + TPcoeff[2];
                        if (dig_T2 > 32767)
                        {
                            dig_T2 -= 65536;
                        }
                        dig_T3 = TPcoeff[5] * 256 + TPcoeff[4];
                        if (dig_T3 > 32767)
                        {
                            dig_T3 -= 65536;
                        }

                        //Pressure coefficents
                        dig_P1 = TPcoeff[7] * 256 + TPcoeff[6];
                        dig_P2 = TPcoeff[9] * 256 + TPcoeff[8];
                        if (dig_P2 > 32767)
                        {
                            dig_P2 -= 65536;
                        }
                        dig_P3 = TPcoeff[11] * 256 + TPcoeff[10];
                        if (dig_P3 > 32767)
                        {
                            dig_P3 -= 65536;
                        }
                        dig_P4 = TPcoeff[13] * 256 + TPcoeff[12];
                        if (dig_P4 > 32767)
                        {
                            dig_P4 -= 65536;
                        }
                        dig_P5 = TPcoeff[15] * 256 + TPcoeff[14];
                        if (dig_P5 > 32767)
                        {
                            dig_P5 -= 65536;
                        }
                        dig_P6 = TPcoeff[17] * 256 + TPcoeff[16];
                        if (dig_P6 > 32767)
                        {
                            dig_P6 -= 65536;
                        }
                        dig_P7 = TPcoeff[19] * 256 + TPcoeff[18];
                        if (dig_P7 > 32767)
                        {
                            dig_P7 -= 65536;
                        }
                        dig_P8 = TPcoeff[21] * 256 + TPcoeff[20];
                        if (dig_P8 > 32767)
                        {
                            dig_P8 -= 65536;
                        }
                        dig_P9 = TPcoeff[23] * 256 + TPcoeff[22];
                        if (dig_P9 > 32767)
                        {
                            dig_P9 -= 65536;
                        }
                    }
                }
                byte[] dig_H1 = CommObj.Send(new byte[] { addr, 0xA1 }, 1);

                //Read Humidity coefficents
                byte[] Hcoeff = CommObj.Send(new byte[] { addr, 0xE1 }, 7);
                if (Hcoeff != null)
                {
                    if (Hcoeff.Length == 7)
                    {
                        //Humidity coefficents
                        dig_H2 = Hcoeff[1] * 256 + Hcoeff[0];
                        if (dig_H2 > 32767)
                        {
                            dig_H2 -= 65536;
                        }
                        dig_H3 = (Hcoeff[2] & 0xFF);
                        dig_H4 = (Hcoeff[3] * 16) + (Hcoeff[4] & 0xF0);
                        if (dig_H4 > 32767)
                        {
                            dig_H4 -= 65536;
                        }
                        dig_H5 = (Hcoeff[4] /16) + (Hcoeff[5] * 16);
                        if (dig_H5 > 32767)
                        {
                            dig_H5 -= 65536;
                        }
                        dig_H6 = Hcoeff[6];
                        if (dig_H5 > 127)
                        {
                            dig_H5 -= 256;
                        }
                    }
                }
                
                //Configure control humidity register
                byte[] value = CommObj.Send(new byte[] { addr, 0xF2, 0x01 }, 0);
                //Configure Control measurement register
                value = CommObj.Send(new byte[] { addr, 0xF4, 0x27 }, 0);
                //Configure Configuration register
                value = CommObj.Send(new byte[] { addr, 0xF5, 0xA0 }, 0);
                Thread.Sleep(500);
                // Read data
                value = CommObj.Send(new byte[] { addr, 0xF7 }, 8);
                if (value != null)
                {
                    if (value.Length == 8)
                    {
                        adc_p = ((value[0] * 65536) + (value[1] * 256) + (value[2] & 0xF0)) / 16;
                        adc_t = ((value[3] * 65536) + (value[4] * 256) + (value[5] & 0xF0)) / 16;
                        adc_h = value[6] * 256 + value[7];
                    }
                }
                //Temperature offset calculations
                double var1 = ((adc_t) / 16384.0 - (dig_T1) / 1024.0) * (dig_T2);
                double var2 = (((adc_t) / 131072.0 - (dig_T1) / 8192.0) * ((adc_t) / 131072.0 - (dig_T1) / 8192.0)) * (dig_T3);
                double t_fine = (var1 + var2);
                double cTemp = (var1 + var2) / 5120.0;
                
                //Pressure offset calculations
                var1 = (t_fine / 2.0) - 64000.0;
                var2 = var1 * var1 * (dig_P6) / 32768.0;
                var2 = var2 + var1 * (dig_P5) * 2.0;
                var2 = (var2 / 4.0) + ((dig_P4) * 65536.0);
                var1 = ((dig_P3) * var1 * var1 / 524288.0 + ( dig_P2) * var1) / 524288.0;
                var1 = (1.0 + var1 / 32768.0) * (dig_P1);
                double p = 1048576.0 - adc_p;
                p = (p - (var2 / 4096.0)) * 6250.0 / var1;
                var1 = (dig_P9) * p * p / 2147483648.0;
                var2 = p * (dig_P8) / 32768.0;
                double pressure = (p + (var1 + var2 + (dig_P7)) / 16.0) / 100;

                //Humidity offset calculations
                double var_H = ((t_fine) - 76800.0);
                var_H = (adc_h - (dig_H4 * 64.0 + dig_H5 / 16384.0 * var_H)) * (dig_H2 / 65536.0 * (1.0 + dig_H6 / 67108864.0 * var_H * (1.0 + dig_H3 / 67108864.0 * var_H)));
                double humidity = var_H * (1.0 -  dig_H1[0] * var_H / 524288.0);
                if(humidity > 100.0)
                {
                    humidity = 100.0;
                }else if(humidity < 0.0)
                {
                    humidity = 0.0;
                }

                lbT.Text = cTemp.ToString("F2");
                lbP.Text = pressure.ToString("F2");
                lbH.Text = humidity.ToString("F2");
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
