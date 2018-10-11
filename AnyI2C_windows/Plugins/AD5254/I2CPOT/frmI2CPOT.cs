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

namespace AD5254_I2CPOT
{
    public partial class frmI2CPOT : Form
    {
        CommInterface CommObj = null;
        byte value1 = 0;
        byte value2 = 0;
        byte value3 = 0;
        byte value4 = 4;
        public frmI2CPOT()
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
            CommObj.Send(new byte[] { addr, 0 , (byte)scrollValue1.Value}, 1);

            //  read data back
            byte[] value = CommObj.Send(new byte[] { addr, 0 }, 1);
            if (value != null)
            {
                Debug.Print("POT1 : " + value[0].ToString());
                value1 = value[0];
                lbTemp1.Text = value1.ToString();
            }

        }

        private void scrollValue2_Scroll(object sender, ScrollEventArgs e)
        {
            byte addr = GetAddress(true);
            // update the pot value
            CommObj.Send(new byte[] { addr, 1, (byte)scrollValue2.Value }, 1);

            //  read data back
            byte[] value = CommObj.Send(new byte[] { addr, 1 }, 1);
            if (value != null)
            {
                Debug.Print("POT2 : " + value[0].ToString());
                value2 = value[0];
                lbTemp2.Text = value2.ToString();
            }
        }

        private void scrollValue3_Scroll(object sender, ScrollEventArgs e)
        {
            byte addr = GetAddress(true);
            // update the pot value
            CommObj.Send(new byte[] { addr, 2, (byte)scrollValue3.Value }, 1);

            // read data back
            byte[] value = CommObj.Send(new byte[] { addr, 2 }, 1);
            if (value != null)
            {
                Debug.Print("POT3 : " + value[0].ToString());
                value3 = value[0];
                lbTemp3.Text = value3.ToString();
            }

        }

        private void scrollValue4_Scroll(object sender, ScrollEventArgs e)
        {
            byte addr = GetAddress(true);
            // update the pot value
            CommObj.Send(new byte[] { addr, 3, (byte)scrollValue4.Value }, 1);

            // read data back
            byte[] value = CommObj.Send(new byte[] { addr, 3 }, 1);
            if (value != null)
            {
                Debug.Print("POT4 : " + value[0].ToString());
                value4 = value[0];
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
            byte[] value = CommObj.Send(new byte[] { addr, 0 }, 1);
            if (value != null)
            {
                Debug.Print("POT1 : " + value[0].ToString());
                value1 = value[0];
                lbTemp1.Text = value1.ToString();
                scrollValue1.Value = value1;
            }
            value = CommObj.Send(new byte[] { addr, 1 }, 1);
            if (value != null)
            {
                Debug.Print("POT2 : " + value[0].ToString());
                value2 = value[0];
                lbTemp2.Text = value2.ToString();
                scrollValue2.Value = value2;
            }
            value = CommObj.Send(new byte[] { addr, 2 }, 1);
            if (value != null)
            {
                Debug.Print("POT3 : " + value[0].ToString());
                value3 = value[0];
                lbTemp3.Text = value3.ToString();
                scrollValue3.Value = value3;
            }
            value = CommObj.Send(new byte[] { addr, 3 }, 1);
            if (value != null)
            {
                Debug.Print("POT4 : " + value[0].ToString());
                value4 = value[0];
                lbTemp4.Text = value4.ToString();
                scrollValue4.Value = value4;
            }
        }

        /// <summary>
        /// Send command, will process address
        /// </summary>
        private byte GetAddress(bool Read)
        {
            return (byte)(numAddress.Value);
        }

        private void frmI2CPOT_Load(object sender, EventArgs e)
        {
            numPort.Value = CommObj.GetPort();
            CommObj.LogText("GUI Opened");
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            CommObj.SetPort((byte)numPort.Value); 
        }

        private void frmI2CPOT_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommObj.LogText("GUI Closed");
        }
    }


    public class MyGUI : GuiInterface
    {
        public void Show(CommInterface com)
        {
            frmI2CPOT frm = new frmI2CPOT();
            frm.Attach(com);
            frm.ShowDialog();
        }
    }
}
