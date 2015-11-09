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

namespace AD5693_I2CDAC
{
    public partial class frmI2CDAC : Form
    {
        CommInterface CommObj = null;
        int value1 = 0;
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
            CommObj.Send(new byte[] { addr, 48, v[0], v[1]}, 0);

            //  read data back
            byte[] value = CommObj.Send(new byte[] { addr, 48 }, 2);
            if (value != null)
            {
                value1 = Get16BitsValue(value);
                Debug.Print("DAC A : " + value1.ToString());
                lbTemp1.Text = value1.ToString();
            }

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            byte addr = GetAddress(true);
            byte[] value = CommObj.Send(new byte[] { addr, 48 }, 2);
            if (value != null)
            {
                value1 = Get16BitsValue(value);
                Debug.Print("DAC A : " + value1.ToString());
                lbTemp1.Text = value1.ToString();
            }
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
