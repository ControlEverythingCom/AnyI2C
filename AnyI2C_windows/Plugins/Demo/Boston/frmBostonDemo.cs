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

        byte currentOutputStatusB1 = 0;
        byte currentOutputStatusB2 = 0;


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
            Thread.Sleep(100);
            InitPWM2();
            InitMCP23017_1();
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

        private void InitPWM2()
        {
            SwitchToPCA9685_PWM2();
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
            return (byte)(numAddress.Value);
        }


        private void frmI2CS_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommObj.LogText("GUI Closed");
            timer1.Enabled = false;
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


        private void SwitchToTSL2561()
        {
            CommObj.SetPort(2);
            numAddress.Value = 0x39;
        }

        private void ReadTSL2561()
        {
            SwitchToTSL2561();
            try
            {
                byte addr = GetAddress(false);
                // write to config
                byte[] value = CommObj.Send(new byte[] { addr, 0x80, 0x03 }, 0);
                value = CommObj.Send(new byte[] { addr, 0x81, 0x10 }, 0);
                value = CommObj.Send(new byte[] { addr, 0x8C }, 4);
                if (value != null)
                {
                    int c0 = value[1] * 256 + value[0];
                    int c1 = value[3] * 256 + value[2];
                    lbCh0.Text = (c0 - c1).ToString("F0");
                    lbCh1.Text = c1.ToString("F0");
                }
            }
            catch
            {
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            ReadSHT25();
            UpdateLED();
            ReadTSL2561();
            SetServo3();
            SetServo4();
            timer1.Enabled = true;
        }


        private void SwitchToPCA9685_PWM2()
        {
            CommObj.SetPort(3);
            numAddress.Value = 0x40;
        }


        private void scrollBarPCA9685_2_C1_Scroll(object sender, ScrollEventArgs e)
        {
            SwitchToPCA9685_PWM2();
            byte addr = GetAddress(false);
            // setup servo1 pos, pulsa width is 20 ms for 50 hz. 0.7 ms is for 0, which is 143, 1.5 ms is for center, which is 429 in 4096
            int off1 = 143 + scrollBarPCA9685_2_C1.Value * 286 / 100;
            byte OffL1 = (byte)(off1 & 0xff);
            byte OffH1 = (byte)(off1 >> 8);
            CommObj.Send(new byte[] { addr, 6, 0 }, 0); // OnL
            CommObj.Send(new byte[] { addr, 7, 0 }, 0); // OnH
            CommObj.Send(new byte[] { addr, 8, OffL1 }, 0); // OffL
            CommObj.Send(new byte[] { addr, 9, OffH1 }, 0); // OffH
            lbPCA9685_2_C1.Text = scrollBarPCA9685_2_C1.Value.ToString() ;
        }

        private void scrollBarPCA9685_2_C2_Scroll(object sender, ScrollEventArgs e)
        {
            SwitchToPCA9685_PWM2();
            byte addr = GetAddress(false);
            // setup servo1 pos, pulsa width is 20 ms for 50 hz. 0.7 ms is for 0, which is 143, 1.5 ms is for center, which is 429 in 4096
            int off1 = 143 + scrollBarPCA9685_2_C2.Value * 286 / 100;
            byte OffL1 = (byte)(off1 & 0xff);
            byte OffH1 = (byte)(off1 >> 8);
            int ch = 1;
            CommObj.Send(new byte[] { addr, 10, 0 }, 0); // OnL
            CommObj.Send(new byte[] { addr, 11, 0 }, 0); // OnH
            CommObj.Send(new byte[] { addr, 12, OffL1 }, 0); // OffL
            CommObj.Send(new byte[] { addr, 13, OffH1 }, 0); // OffH
            lbPCA9685_2_C2.Text = scrollBarPCA9685_2_C2.Value.ToString();
        }

        private void scrollBarPCA9685_2_C3_Scroll(object sender, ScrollEventArgs e)
        {
            SwitchToPCA9685_PWM2();
            byte addr = GetAddress(false);
            // setup servo1 pos, pulsa width is 20 ms for 50 hz. 0.7 ms is for 0, which is 143, 1.5 ms is for center, which is 429 in 4096
            int off1 = 143 + scrollBarPCA9685_2_C3.Value * 286 / 100;
            byte OffL1 = (byte)(off1 & 0xff);
            byte OffH1 = (byte)(off1 >> 8);
            CommObj.Send(new byte[] { addr, 14, 0 }, 0); // OnL
            CommObj.Send(new byte[] { addr, 15, 0 }, 0); // OnH
            CommObj.Send(new byte[] { addr, 16, OffL1 }, 0); // OffL
            CommObj.Send(new byte[] { addr, 17, OffH1 }, 0); // OffH
            lbPCA9685_2_C3.Text = scrollBarPCA9685_2_C3.Value.ToString();
        }

        private void scrollBarPCA9685_2_C4_Scroll(object sender, ScrollEventArgs e)
        {
            SwitchToPCA9685_PWM2();
            byte addr = GetAddress(false);
            // setup servo1 pos, pulsa width is 20 ms for 50 hz. 0.7 ms is for 0, which is 143, 1.5 ms is for center, which is 429 in 4096
            int off1 = 143 + scrollBarPCA9685_2_C4.Value * 286 / 100;
            byte OffL1 = (byte)(off1 & 0xff);
            byte OffH1 = (byte)(off1 >> 8);
            CommObj.Send(new byte[] { addr, 18, 0 }, 0); // OnL
            CommObj.Send(new byte[] { addr, 19, 0 }, 0); // OnH
            CommObj.Send(new byte[] { addr, 20, OffL1 }, 0); // OffL
            CommObj.Send(new byte[] { addr, 21, OffH1 }, 0); // OffH
            lbPCA9685_2_C4.Text = scrollBarPCA9685_2_C4.Value.ToString();
        }

        private void SetServo3()
        {
            SwitchToPCA9685_PWM2();
            byte addr = GetAddress(false);
            // setup servo1 pos, pulsa width is 20 ms for 50 hz. 0.7 ms is for 0, which is 143, 1.5 ms is for center, which is 429 in 4096
            int off1 = 143 + (int)humidity * 286 / 100;
            byte OffL1 = (byte)(off1 & 0xff);
            byte OffH1 = (byte)(off1 >> 8);
            CommObj.Send(new byte[] { addr, 14, 0 }, 0); // OnL
            CommObj.Send(new byte[] { addr, 15, 0 }, 0); // OnH
            CommObj.Send(new byte[] { addr, 16, OffL1 }, 0); // OffL
            CommObj.Send(new byte[] { addr, 17, OffH1 }, 0); // OffH
            lbPCA9685_2_C3.Text = ((int)humidity).ToString();
        }

        private void SetServo4()
        {
            SwitchToPCA9685_PWM2();
            byte addr = GetAddress(false);
            // setup servo1 pos, pulsa width is 20 ms for 50 hz. 0.7 ms is for 0, which is 143, 1.5 ms is for center, which is 429 in 4096
            int off1 = 143 + (int)temperatureF * 286 / 100;
            byte OffL1 = (byte)(off1 & 0xff);
            byte OffH1 = (byte)(off1 >> 8);
            CommObj.Send(new byte[] { addr, 18, 0 }, 0); // OnL
            CommObj.Send(new byte[] { addr, 19, 0 }, 0); // OnH
            CommObj.Send(new byte[] { addr, 20, OffL1 }, 0); // OffL
            CommObj.Send(new byte[] { addr, 21, OffH1 }, 0); // OffH
            lbPCA9685_2_C3.Text = ((int)temperatureF).ToString();
        }

        private void SwitchToMCP23017_1()
        {
            CommObj.SetPort(4);
            numAddress.Value = 0x20;

        }

        private void SwitchToMCP23017_2()
        {

        }

        private void InitMCP23017_1()
        {
            try
            {
                //_ERROR.Visible = false;
                byte addr = GetAddress(false);
                CommObj.Send(new byte[] { addr, 0, 0 }, 0);
                CommObj.Send(new byte[] { addr, 1, 0 }, 0);
                addr = GetAddress(true);
                byte[] value = CommObj.Send(new byte[] { addr, 18 }, 1);
                if (value != null)
                {
                    Debug.Print(value[0].ToString());
                    currentOutputStatusB1 = value[0];
                }
                value = CommObj.Send(new byte[] { addr, 19 }, 1);
                if (value != null)
                {
                    Debug.Print(value[0].ToString());
                    currentOutputStatusB2 = value[0];
                }
            }
            catch
            {
                //_ERROR.Visible = true;
            }

        }


        private void UpdateStatus()
        {
            SwitchToMCP23017_1();
            try
            {
                //_ERROR.Visible = false;
                byte addr = GetAddress(false);
                addr = GetAddress(true);
                byte[] value = CommObj.Send(new byte[] { addr, 18 }, 1);
                if (value != null)
                {
                    Debug.Print(value[0].ToString());
                    currentOutputStatusB1 = value[0];
                }
                value = CommObj.Send(new byte[] { addr, 19 }, 1);
                if (value != null)
                {
                    Debug.Print(value[0].ToString());
                    currentOutputStatusB2 = value[0];
                }
            }
            catch
            {
                //_ERROR.Visible = true;
            }

            chkB1R1.Checked = GetOneOutputStatus(currentOutputStatusB1, 0);
            chkB1R2.Checked = GetOneOutputStatus(currentOutputStatusB1, 1);
            chkB1R3.Checked = GetOneOutputStatus(currentOutputStatusB1, 2);
            chkB1R4.Checked = GetOneOutputStatus(currentOutputStatusB1, 3);
            chkB1R5.Checked = GetOneOutputStatus(currentOutputStatusB1, 4);
            chkB1R6.Checked = GetOneOutputStatus(currentOutputStatusB1, 5);
            chkB1R7.Checked = GetOneOutputStatus(currentOutputStatusB1, 6);
            chkB1R8.Checked = GetOneOutputStatus(currentOutputStatusB1, 7);

            chkB2R1.Checked = GetOneOutputStatus(currentOutputStatusB2, 0);
            chkB2R2.Checked = GetOneOutputStatus(currentOutputStatusB2, 1);
            chkB2R3.Checked = GetOneOutputStatus(currentOutputStatusB2, 2);
            chkB2R4.Checked = GetOneOutputStatus(currentOutputStatusB2, 3);
            chkB2R5.Checked = GetOneOutputStatus(currentOutputStatusB2, 4);
            chkB2R6.Checked = GetOneOutputStatus(currentOutputStatusB2, 5);
            chkB2R7.Checked = GetOneOutputStatus(currentOutputStatusB2, 6);
            chkB2R8.Checked = GetOneOutputStatus(currentOutputStatusB2, 7);

            //CheckBox1.Checked = GetOneOutputStatus(currentOutputStatus, 0);
            //checkBox2.Checked = GetOneOutputStatus(currentOutputStatus, 1);
            //checkBox3.Checked = GetOneOutputStatus(currentOutputStatus, 2);
            //checkBox4.Checked = GetOneOutputStatus(currentOutputStatus, 3);
            //lbInput5.Text = GetStatusString(currentOutputStatus, 4);
            //lbInput6.Text = GetStatusString(currentOutputStatus, 5);
            //lbInput7.Text = GetStatusString(currentOutputStatus, 6);
            //lbInput8.Text = GetStatusString(currentOutputStatus, 7);
        }

        private string GetStatusString(byte value, byte pos)
        {
            byte bitValue = ByteLib.GetBit(value, pos);
            if (bitValue == 1)
            {
                return "Hi";
            }
            return "Low";

        }

        private void btnReadInput_Click(object sender, EventArgs e)
        {
            UpdateStatus();
        }



        /// <summary>
        /// update one bit of the output for bank 1
        /// </summary>
        /// <param name="value"></param>
        /// <param name="pos"></param>
        private void UpdateOneBitB1(byte value, byte pos)
        {
            SwitchToMCP23017_1();

            try
            {
                currentOutputStatusB1 = ByteLib.SetBit(currentOutputStatusB1, pos, value);
                byte addr = GetAddress(true);
                CommObj.Send(new byte[] { addr, 18, currentOutputStatusB1 }, 0);
            }
            catch
            {

            }
        }

        /// <summary>
        /// update one bit of the output for bank 2
        /// </summary>
        /// <param name="value"></param>
        /// <param name="pos"></param>
        private void UpdateOneBitB2(byte value, byte pos)
        {
            SwitchToMCP23017_1();

            try
            {
                currentOutputStatusB2 = ByteLib.SetBit(currentOutputStatusB2, pos, value);
                byte addr = GetAddress(true);
                CommObj.Send(new byte[] { addr, 19, currentOutputStatusB2 }, 0);
            }
            catch
            {

            }
        }


        private bool GetOneOutputStatus(byte value, byte pos)
        {
            bool status = false;
            if (ByteLib.GetBit(value, pos) == 1)
            {
                status = true;
            }
            return status;
        }

        private void chkB1R1_Clicked(object sender, EventArgs e)
        {
            if (chkB1R1.Checked)
            {
                UpdateOneBitB1(1, 0);
            }
            else
            {
                UpdateOneBitB1(0, 0);
            }

        }

        private void chkB1R2_Click(object sender, EventArgs e)
        {
            if (chkB1R2.Checked)
            {
                UpdateOneBitB1(1, 1);
            }
            else
            {
                UpdateOneBitB1(0, 1);
            }

        }

        private void chkB1R3_Click(object sender, EventArgs e)
        {
            if (chkB1R3.Checked)
            {
                UpdateOneBitB1(1, 2);
            }
            else
            {
                UpdateOneBitB1(0, 2);
            }

        }

        private void chkB1R4_Click(object sender, EventArgs e)
        {
            if (chkB1R4.Checked)
            {
                UpdateOneBitB1(1, 3);
            }
            else
            {
                UpdateOneBitB1(0, 3);
            }

        }

        private void chkB1R5_Click(object sender, EventArgs e)
        {
            if (chkB1R5.Checked)
            {
                UpdateOneBitB1(1, 4);
            }
            else
            {
                UpdateOneBitB1(0, 4);
            }

        }

        private void chkB1R6_Click(object sender, EventArgs e)
        {
            if (chkB1R6.Checked)
            {
                UpdateOneBitB1(1, 5);
            }
            else
            {
                UpdateOneBitB1(0, 5);
            }

        }

        private void chkB1R7_Click(object sender, EventArgs e)
        {
            if (chkB1R7.Checked)
            {
                UpdateOneBitB1(1, 6);
            }
            else
            {
                UpdateOneBitB1(0, 6);
            }

        }

        private void chkB1R8_Click(object sender, EventArgs e)
        {
            if (chkB1R8.Checked)
            {
                UpdateOneBitB1(1, 7);
            }
            else
            {
                UpdateOneBitB1(0, 7);
            }

        }

        private void chkB2R1_Click(object sender, EventArgs e)
        {
            if (chkB2R1.Checked)
            {
                UpdateOneBitB2(1, 0);
            }
            else
            {
                UpdateOneBitB2(0, 0);
            }
        }

        private void chkB2R2_Click(object sender, EventArgs e)
        {
            if (chkB2R1.Checked)
            {
                UpdateOneBitB2(1, 1);
            }
            else
            {
                UpdateOneBitB2(0, 1);
            }
        }

        private void chkB2R3_Click(object sender, EventArgs e)
        {
            if (chkB2R3.Checked)
            {
                UpdateOneBitB2(1, 2);
            }
            else
            {
                UpdateOneBitB2(0, 2);
            }

        }

        private void chkB2R4_Click(object sender, EventArgs e)
        {
            if (chkB2R4.Checked)
            {
                UpdateOneBitB2(1, 3);
            }
            else
            {
                UpdateOneBitB2(0, 3);
            }

        }

        private void chkB2R5_Click(object sender, EventArgs e)
        {
            if (chkB2R5.Checked)
            {
                UpdateOneBitB2(1, 4);
            }
            else
            {
                UpdateOneBitB2(0, 4);
            }

        }

        private void chkB2R6_Click(object sender, EventArgs e)
        {
            if (chkB2R6.Checked)
            {
                UpdateOneBitB2(1, 5);
            }
            else
            {
                UpdateOneBitB2(0, 5);
            }

        }

        private void chkB2R7_Click(object sender, EventArgs e)
        {
            if (chkB2R7.Checked)
            {
                UpdateOneBitB2(1, 6);
            }
            else
            {
                UpdateOneBitB2(0, 6);
            }

        }

        private void chkB2R8_Click(object sender, EventArgs e)
        {
            if (chkB2R8.Checked)
            {
                UpdateOneBitB2(1, 7);
            }
            else
            {
                UpdateOneBitB2(0, 7);
            }

        }

        private void btnRead1_Click(object sender, EventArgs e)
        {
            SwitchToMCP23017_1();

            try
            {
                //_ERROR.Visible = false;
                byte addr = GetAddress(false);
                addr = GetAddress(true);
                byte[] value = CommObj.Send(new byte[] { addr, 18 }, 1);
                if (value != null)
                {
                    Debug.Print(value[0].ToString());
                    currentOutputStatusB1 = value[0];
                }
            }
            catch
            {
                //_ERROR.Visible = true;
            }

            chkB1R1.Checked = GetOneOutputStatus(currentOutputStatusB1, 0);
            chkB1R2.Checked = GetOneOutputStatus(currentOutputStatusB1, 1);
            chkB1R3.Checked = GetOneOutputStatus(currentOutputStatusB1, 2);
            chkB1R4.Checked = GetOneOutputStatus(currentOutputStatusB1, 3);
            chkB1R5.Checked = GetOneOutputStatus(currentOutputStatusB1, 4);
            chkB1R6.Checked = GetOneOutputStatus(currentOutputStatusB1, 5);
            chkB1R7.Checked = GetOneOutputStatus(currentOutputStatusB1, 6);
            chkB1R8.Checked = GetOneOutputStatus(currentOutputStatusB1, 7);

        }

        private void btnRead2_Click(object sender, EventArgs e)
        {
            SwitchToMCP23017_1();

            try
            {
                //_ERROR.Visible = false;
                byte addr = GetAddress(true);
                byte[] value = CommObj.Send(new byte[] { addr, 19 }, 1);
                if (value != null)
                {
                    Debug.Print(value[0].ToString());
                    currentOutputStatusB2 = value[0];
                }
            }
            catch
            {
                //_ERROR.Visible = true;
            }


            chkB2R1.Checked = GetOneOutputStatus(currentOutputStatusB2, 0);
            chkB2R2.Checked = GetOneOutputStatus(currentOutputStatusB2, 1);
            chkB2R3.Checked = GetOneOutputStatus(currentOutputStatusB2, 2);
            chkB2R4.Checked = GetOneOutputStatus(currentOutputStatusB2, 3);
            chkB2R5.Checked = GetOneOutputStatus(currentOutputStatusB2, 4);
            chkB2R6.Checked = GetOneOutputStatus(currentOutputStatusB2, 5);
            chkB2R7.Checked = GetOneOutputStatus(currentOutputStatusB2, 6);
            chkB2R8.Checked = GetOneOutputStatus(currentOutputStatusB2, 7);


        }

        private void btnAllOn1_Click(object sender, EventArgs e)
        {
            SwitchToMCP23017_1();

            byte addr = GetAddress(true);
            CommObj.Send(new byte[] { addr, 18, 255 }, 0);
            UpdateStatus();
        }

        private void btnAllOff1_Click(object sender, EventArgs e)
        {
            SwitchToMCP23017_1();

            byte addr = GetAddress(true);
            CommObj.Send(new byte[] { addr, 18, 0 }, 0);
            UpdateStatus();
        }

        private void btnAllOn2_Click(object sender, EventArgs e)
        {
            SwitchToMCP23017_1();

            byte addr = GetAddress(true);
            CommObj.Send(new byte[] { addr, 19, 255 }, 0);
            UpdateStatus();
        }

        private void btnAllOff2_Click(object sender, EventArgs e)
        {
            SwitchToMCP23017_1();

            byte addr = GetAddress(true);
            CommObj.Send(new byte[] { addr, 19, 0 }, 0);
            UpdateStatus();
        }

        private void chkB1R1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

    public class ByteLib
    {

        /// <summary>
        /// return the specific bit value
        /// </summary>
        /// <param name="v"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        static public byte GetBit(byte v, byte pos)
        {
            byte value = (byte)(1 << pos);
            byte result = (byte)((v & value) > 0 ? 1 : 0);

            return result;
        }

        /// <summary>
        /// return the new value with specific bit set
        /// </summary>
        /// <param name="v"></param>
        /// <param name="pos"></param>
        /// <param name="bitValue"></param>
        /// <returns></returns>
        static public byte SetBit(byte v, byte pos, byte bitValue)
        {
            byte result = v;
            byte value = (byte)(1 << pos);
            result = (byte)(v | value);
            result = (byte)(result - value);
            value = (byte)(bitValue << pos);
            result = (byte)(result + value);
            return result;
        }

        public enum emCheckSumMethod
        {
            CS_A_B = 0                  // check sum by plus all bytes together and mod with 0x100
            ,
            CS_FF_A_B             // check sum by 0xFF minus value in CS_A_B, like zig bee device
                ,
            CS_100_A_B            // check sum by 0x100 minus value in CS_A_B
                ,
            FLETCHER              // Fletcher's Checksum
                ,
            XOR                   // xor
                ,
            CRC16Standard         // CRC 16 standard = 0xA001
                ,
            CRC16CCITT            // CRC 16 CCITT Kermit = 0x8408   
                , CS_FF_OR              // check by 0xFF or all bytes together

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
