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

namespace BostonDemo
{
    public partial class frmBostonDemo : Form
    {
        CommInterface CommObj = null;

        double humidity;
        double temperature;
        double temperatureF;

        public frmBostonDemo()
        {
            InitializeComponent();
            humidity = 0;
            temperature = 0;
        }

        private void frmI2CS_Load(object sender, EventArgs e)
        {

            CommObj.LogText("GUI Opened");
            numAddress.Value = CommObj.GetDefaultAddress();
            numPort.Value = CommObj.GetPort();
            InitPWM1();
            timer1.Enabled = true;
        }


        public void Attach(CommInterface com)
        {
            CommObj = com;
        }


        private void InitPWM1()
        {
            SwitchToPCA9685_PWM1();
            int freq = 50;  // 50 hz, for servos, works with led too
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

        private void SwitchToPCA9685_PWM1()
        {
            CommObj.SetPort(0);
            numAddress.Value = 0x40;
        }

        private void scrollBarPCA9685_1_C1_Scroll(object sender, ScrollEventArgs e)
        {
            SwitchToPCA9685_PWM1();
            byte off = (byte)scrollBarPCA9685_1_C1.Value;
            byte led = 0;
            byte addr = GetAddress(false);
            CommObj.Send(new byte[] { addr, (byte)(6 + 4 * led), 0 }, 0);
            CommObj.Send(new byte[] { addr, (byte)(7 + 4 * led), 0 }, 0);
            CommObj.Send(new byte[] { addr, (byte)(8 + 4 * led), 0 }, 0);
            CommObj.Send(new byte[] { addr, (byte)(9 + 4 * led), off}, 0);
            lbPCA9685_1_C1.Text = off.ToString();

        }

        private void scrollBarPCA9685_1_C2_Scroll(object sender, ScrollEventArgs e)
        {
            SwitchToPCA9685_PWM1();
            byte off = (byte)scrollBarPCA9685_1_C2.Value;
            byte led = 1;
            byte addr = GetAddress(false);
            CommObj.Send(new byte[] { addr, (byte)(6 + 4 * led), 0 }, 0);
            CommObj.Send(new byte[] { addr, (byte)(7 + 4 * led), 0 }, 0);
            CommObj.Send(new byte[] { addr, (byte)(8 + 4 * led), 0 }, 0);
            CommObj.Send(new byte[] { addr, (byte)(9 + 4 * led), off }, 0);
            lbPCA9685_1_C2.Text = off.ToString();

        }

        private void scrollBarPCA9685_1_C3_Scroll(object sender, ScrollEventArgs e)
        {
            SwitchToPCA9685_PWM1();
            byte off = (byte)scrollBarPCA9685_1_C3.Value;
            byte led = 2;
            byte addr = GetAddress(false);
            CommObj.Send(new byte[] { addr, (byte)(6 + 4 * led), 0 }, 0);
            CommObj.Send(new byte[] { addr, (byte)(7 + 4 * led), 0 }, 0);
            CommObj.Send(new byte[] { addr, (byte)(8 + 4 * led), 0 }, 0);
            CommObj.Send(new byte[] { addr, (byte)(9 + 4 * led), off }, 0);
            lbPCA9685_1_C3.Text = off.ToString();

        }

        private void scrollBarPCA9685_1_C4_Scroll(object sender, ScrollEventArgs e)
        {
            SwitchToPCA9685_PWM1();
            byte off = (byte)scrollBarPCA9685_1_C4.Value;
            byte led = 3;
            byte addr = GetAddress(false);
            CommObj.Send(new byte[] { addr, (byte)(6 + 4 * led), 0 }, 0);
            CommObj.Send(new byte[] { addr, (byte)(7 + 4 * led), 0 }, 0);
            CommObj.Send(new byte[] { addr, (byte)(8 + 4 * led), 0 }, 0);
            CommObj.Send(new byte[] { addr, (byte)(9 + 4 * led), off }, 0);
            lbPCA9685_1_C4.Text = off.ToString();

        }


        private void SwitchToSHT25()
        {
            CommObj.SetPort(1);
            numAddress.Value = 0x40;

        }


        private void ReadSHT25()
        {
            SwitchToSHT25();
            string valuePair = string.Empty;
            try
            {

                // Read Humidity
                byte addr = GetAddress(false);
                int retry = 0;
                bool success = false;
                CommObj.Send(new byte[] { addr, 0xF5 }, 0);
                Thread.Sleep(10);
                while (!success && retry < 10)   // try 10 times
                {
                    byte[] value = CommObj.Send(new byte[] { addr }, 2);
                    if (value != null)
                    {
                        if (value.Length == 2)
                        {
                            success = true;
                            humidity = 125.0 * (value[0] * 256 + value[1]) / 65536.0 - 6.0;
                            //lbH.Text = humidity.ToString("F2");
                            break;
                        }

                    }
                    Thread.Sleep(100);
                    retry++;
                }
                if (!success)
                {
                    throw new Exception("Fail to read humidity");
                }
                retry = 0;
                success = false;
                // read temperature
                CommObj.Send(new byte[] { addr, 0xF3 }, 0);
                Thread.Sleep(100);
                while (!success && retry < 10)   // try 10 times
                {
                    byte[] value = CommObj.Send(new byte[] { addr }, 2);
                    if (value != null)
                    {
                        if (value.Length == 2)
                        {
                            success = true;
                            temperature = 175.72 * (value[0] * 256 + value[1]) / 65536.0 - 46.85;
                            temperatureF = temperature * 1.8 + 32;
                            //lbT.Text = temp.ToString("F2");
                            break;
                        }
                    }
                    retry++;
                    Thread.Sleep(100);
                }
                lbHum.Text = humidity.ToString("F1");
                lbTemperature.Text = string.Format("{0:F1} C   {1:F1} F", temperature, temperatureF);
                

                if (!success)
                {
                    throw new Exception("Fail to read temperature");
                }

                valuePair = string.Format("Humidity {0:F2}  Temperature {1:F2}", humidity, temperature);
            }
            catch
            {
                valuePair = string.Format("Fail to Read SHT25");
            }

            
        }


        private void SwitchToLED()
        {
            CommObj.SetPort(1);
            numAddress.Value = 0;
        }

        private void UpdateLED()
        {
            SwitchToLED();
            string valuePair = string.Empty;
            try
            {
                byte addr = GetAddress(false);

                // initial
                CommObj.Send(new byte[] { addr, 9, 7 }, 0);
                CommObj.Send(new byte[] { addr, 0xa, 0xff }, 0);
                CommObj.Send(new byte[] { addr, 0xc, 0x01 }, 0);
                CommObj.Send(new byte[] { addr, 0xe, 0 }, 0);
                CommObj.Send(new byte[] { addr, 0xB, 3 }, 0);

                //CommObj.Send(new byte[] { addr, 0x1, 0 }, 0);
                //CommObj.Send(new byte[] { addr, 0x2, 0 }, 0);
                //CommObj.Send(new byte[] { addr, 0x3, 0 }, 0);

                byte d1 = (byte)((int)temperatureF / 10);
                byte d2 = (byte)(((int)temperatureF - d1 * 10));
                byte d3 = (byte)((int)((temperatureF - d1 * 10 - d2) * 10));
                CommObj.Send(new byte[] { addr, 1, d1 }, 0);
                CommObj.Send(new byte[] { addr, 2, (byte)(d2 + 128) }, 0);
                CommObj.Send(new byte[] { addr, 3, d3 }, 0);

            }
            catch
            {
                valuePair = string.Format("Fail set LED");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ReadSHT25();
            UpdateLED();
        }
    }

    public class MyGUI : GuiInterface
    {
        public void Show(CommInterface com)
        {
            frmBostonDemo frm = new frmBostonDemo();
            frm.Attach(com);
            frm.ShowDialog();
        }
    }
}
