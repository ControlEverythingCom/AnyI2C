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

namespace BMP280_I2CS
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

        // 
        double ReadUnsignedShort(byte RegAddr)
        {
            byte addr = GetAddress(true);
            byte[] value = CommObj.Send(new byte[] { addr, RegAddr}, 2);
            if(value != null)
            {
                if(value.Length == 2)
                {
                    return value[1] *256 + value[0];
                }
            }
            throw new Exception("Error Read");
        }

        double ReadSignedShort(byte RegAddr)
        {
            byte addr = GetAddress(true);
            byte[] value = CommObj.Send(new byte[] { addr, RegAddr }, 2);
            if (value != null)
            {
                if (value.Length == 2)
                {
                    if (value[1] < 128)
                    {
                        return value[1] * 256 + value[0];
                    }
                    else
                    {
                        return value[1] * 256 + value[0] - 65536;
                    }
                }
            }
            throw new Exception("Error Read");
        }

        private string ReadSensor()
        {
            try
            {
                _ERROR.Visible = false;

                byte addr = GetAddress(false);
                // read compensation data
                // Configure Sensor
                byte[] value = CommObj.Send(new byte[] { addr, 244, 147}, 0);
                Thread.Sleep(500);
                value = CommObj.Send(new byte[] { addr, 247 }, 6);
                //if (value != null)
                //{
                //    if (value.Length == 6)
                //    {
                        double adc_P = value[0] * 256 * 16 + value[1] * 16 + value[2]/16;
                        double adc_T = value[3] * 256 * 16 + value[4] * 16 + value[5]/16;
                        //adc_T = 519888;
                //    }
                //}
                double T1 = ReadUnsignedShort(0x88);
                double T2 = ReadSignedShort(0x8A);
                double T3 = ReadSignedShort(0x8C);
                double P1 = ReadUnsignedShort(0x8E);
                double P2 = ReadSignedShort(0x90);
                double P3 = ReadSignedShort(0x92);
                double P4 = ReadSignedShort(0x94);
                double P5 = ReadSignedShort(0x96);
                double P6 = ReadSignedShort(0x98);
                double P7 = ReadSignedShort(0x9A);
                double P8 = ReadSignedShort(0x9C);
                double P9 = ReadSignedShort(0x9E);
                //T1 = 27504;
                //T2 = 26435;
                //T3 = -1000;

                //P1 = 36477;
                //P2 = -10685;
                //P3 = 3024;
                //P4 = 2855;
                //P5 = 140;
                //P6 = -7;
                //P7 = 15500;
                //P8 = -14600;
                //P9 = 6000;
                


                double var1 = (((double)adc_T) / 16384.0 - ((double)T1 )/ 1024.0) * T2;
                double var2 = ((((double)adc_T)/ 131072.0 - ((double)T1) / 8192.0) * (((double)adc_T )/ 131072.0 - ((double)T1 )/ 8192.0)) * T3;
                double T = (var1 + var2)/5120.0;
                lbT.Text = T.ToString("F2");
                double tfine = (var1 + var2);
                //tfine = 128422;
                //adc_P = 415148;
                var1 = ((double)tfine / 2.0) - 64000.0;
                var2 = var1 * var1 * ((double)P6) / 32768;
                var2 = var2 + var1 * ((double)P5) * 2.0;
                var2 = (var2 / 4.0) + (((double)P4) * 65536);
                var1 = (((double)P3)*var1 * var1 /522488.0 +((double)P2)*var1)/524288;
                var1 = (1.0 + var1 / 32768.00) * P1;
                double p = 1048576.0 -adc_P;
                p =(p-(var2/4096.0))*6250/var1;
                var1 = ((double )P9 )* p *p /2147483648.0;
                var2 = p* (double )P8/32768;
                p = p + (var1 + var2 + P7)/16;
                p = p / 100.0;
                lbP.Text = p.ToString("F2");
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

        private void frmI2CS_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            CommObj.LogText("GUI Closed");
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
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
