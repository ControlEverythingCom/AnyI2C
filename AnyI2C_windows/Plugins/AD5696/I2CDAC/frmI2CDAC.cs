using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AnyI2C;

namespace AD5696_I2CDAC
{
    public partial class frmI2CDAC : Form
    {
        CommInterface CommObj = null;
        int value1 = 0;
        int value2 = 0;
        int value3 = 0;
        int value4 = 4;
        public frmI2CDAC()
        {
            InitializeComponent();
        }
        
        public void Attach(CommInterface com)
        {
            CommObj = com;
        }        
        private void scrollValue1_Scroll(object sender, ScrollEventArgs e)
        {
            
            byte addr = GetAddress(true);
            // update the pot
            byte[] v = Get16Bytes(scrollValue1.Value);
            CommObj.Send(new byte[] { addr, 49, v[0], v[1]}, 0);

            //  read data back
            byte[] value = CommObj.Send(new byte[] { addr, 49 }, 2);
            if (value != null)
            {
                value1 = Get16BitsValue(value);
                Debug.Print("DAC A : " + value1.ToString());
                lbTemp1.Text = value1.ToString();
            }

        }


        private void scrollValue2_Scroll(object sender, ScrollEventArgs e)
        {
            byte addr = GetAddress(true);
            // update the pot value
            byte[] v = Get16Bytes(scrollValue2.Value);
            CommObj.Send(new byte[] { addr, 50, v[0], v[1]}, 0);

            //  read data back
            byte[] value = CommObj.Send(new byte[] { addr, 50 }, 2);
            if (value != null)
            {
                value2 = Get16BitsValue(value);
                Debug.Print("DAC B : " + value2.ToString());
                lbTemp2.Text = value2.ToString();
            }
        }

        private void scrollValue3_Scroll(object sender, ScrollEventArgs e)
        {
            byte addr = GetAddress(true);
            // update the pot value
            byte[] v = Get16Bytes(scrollValue3.Value);
            CommObj.Send(new byte[] { addr, 52, v[0], v[1]}, 0);

            // read data back
            byte[] value = CommObj.Send(new byte[] { addr, 52 }, 2);
            if (value != null)
            {
                value3 = Get16BitsValue(value);
                Debug.Print("DAC C : " + value3.ToString());
                lbTemp3.Text = value3.ToString();
            }

        }

        private void scrollValue4_Scroll(object sender, ScrollEventArgs e)
        {
            byte addr = GetAddress(true);
            // update the pot value
            byte [] v = Get16Bytes(scrollValue4.Value);
            CommObj.Send(new byte[] { addr, 56, v[0], v[1]}, 0);

            // read data back
            byte[] value = CommObj.Send(new byte[] { addr, 56}, 2);
            if (value != null)
            {
                value4 = Get16BitsValue(value);
                Debug.Print("DAC D: " + value4.ToString());
                lbTemp4.Text = value4.ToString();
            }

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            UpdateAllChannels();
        }

        private void UpdateAllChannels()
        {
            byte addr = GetAddress(true);
            byte[] value = CommObj.Send(new byte[] { addr, 49 }, 2);
            if (value != null)
            {
                value1 = Get16BitsValue(value);
                Debug.Print("DAC A : " + value1.ToString());
                lbTemp1.Text = value1.ToString();
            }

            value = CommObj.Send(new byte[] { addr, 50 }, 2);
            if (value != null)
            {
                value2 = Get16BitsValue(value);
                Debug.Print("DAC B : " + value2.ToString());
                lbTemp2.Text = value2.ToString();
            }
            value = CommObj.Send(new byte[] { addr, 52 }, 2);
            if (value != null)
            {
                value3 = Get16BitsValue(value);
                Debug.Print("DAC C : " + value3.ToString());
                lbTemp3.Text = value3.ToString();
            }
            value = CommObj.Send(new byte[] { addr, 56 }, 2);
            if (value != null)
            {
                value4 = Get16BitsValue(value);
                Debug.Print("DAC D: " + value4.ToString());
                lbTemp4.Text = value4.ToString();
            }
        }

        /// <summary>
        /// Send command, will process address
        /// </summary>
        private byte GetAddress(bool Read)
        {
            return (byte)(numAddress.Value);
        }

        /// <summary>
        /// get the msb and lsb of 16 bit value, first byte is msb, second byte is lsb
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private byte[] Get16Bytes(int value)
        {
            byte[] v = new byte[2];
            v[0] = (byte)(value >> 8);
            v[1] = (byte)(value & 0xff);
            return v;
        }

        /// <summary>
        /// return 16 bits value for 2 bytes, msb, lsb 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private int Get16BitsValue(byte[] value)
        {
            int v = (value[0] * 256 + value[1]);
            return v;
        }

        private void frmI2CDAC_Load(object sender, EventArgs e)
        {
            numPort.Value = CommObj.GetPort();
            CommObj.LogText("GUI Opened");
        }

        private void frmI2CPOT_FormClosing(object sender, FormClosingEventArgs e)
        {
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
            frmI2CDAC frm = new frmI2CDAC();
            frm.Attach(com);
            frm.ShowDialog();
        }
    }
}
