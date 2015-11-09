using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace AnyI2C.Controls.I2C
{

    public delegate void OnValueChange(Object sender, byte v, int id);
    public partial class ctlI2CByte : UserControl
    {
        public event OnValueChange OnValueChange;
        public byte mValue = 0; // value of byte
        private int mID = 0;
        Label[] BitLabelArray = new Label[8];
        bool TriggerEvent = true;
        public byte Value
        {
            get
            {
                return mValue;
            }
            set
            {
                TriggerEvent = false;
                mValue = value;
                UpdateByteValue();
                TriggerEvent = true;

            }
        }

        /// <summary>
        /// set the id caption of the control
        /// </summary>
        /// <param name="id"></param>
        public void SetID(int id)
        {
            lbID.Text = id.ToString();
            mID = id;
        }

        public ctlI2CByte()
        {
            InitializeComponent();
            BitLabelArray[0] = B0;
            BitLabelArray[1] = B1;
            BitLabelArray[2] = B2;
            BitLabelArray[3] = B3;
            BitLabelArray[4] = B4;
            BitLabelArray[5] = B5;
            BitLabelArray[6] = B6;
            BitLabelArray[7] = B7;

        }

        private void B7_Click(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            byte pos = byte.Parse((string)l.Tag);
            byte bitV = ByteLib.GetBit(mValue, pos);
            bitV = (byte)((bitV == 0) ? 1 : 0);
            mValue = ByteLib.SetBit(mValue, pos, bitV);
            UpdateByteValue();
        }

        /// <summary>
        /// update bit lables with address value
        /// </summary>
        private void UpdateByteValue()
        {
            for (byte i = 0; i < 8; i++)
            {
                byte v = ByteLib.GetBit(mValue, i);
                BitLabelArray[i].Text = (v == 1) ? "1" : "0";
                if (v == 1)
                {
                    BitLabelArray[i].BackColor = Color.LightGreen;
                }
                else
                {
                    BitLabelArray[i].BackColor = Color.White;
                }
            }
            txtDec.Text = string.Format("{0}", mValue);
            txtHex.Text = string.Format("{0:X}", mValue);
            if (OnValueChange != null && TriggerEvent)
            {
                OnValueChange(this, mValue, mID);
            }

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            mValue = (byte)(mValue + 1);
            UpdateByteValue();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            mValue = (byte)(mValue - 1);
            UpdateByteValue();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            mValue = (byte)(mValue << 1);
            UpdateByteValue();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            mValue = (byte)(mValue >> 1);
            UpdateByteValue();
        }

        private void txtDec_TextChanged(object sender, EventArgs e)
        {
            byte v = mValue;
            try
            {
                v = byte.Parse(txtDec.Text);
                mValue = v;
                UpdateByteValue();
                txtDec.BackColor = Color.White;
            }
            catch
            {
                txtDec.BackColor = Color.Red;
            }
        }

        private void txtHex_TextChanged(object sender, EventArgs e)
        {
            byte v = mValue;
            try
            {
                v = byte.Parse(txtHex.Text,System.Globalization.NumberStyles.HexNumber);
                mValue = v;
                UpdateByteValue();
                txtHex.BackColor = Color.White;
            }
            catch
            {
                txtHex.BackColor = Color.Red;
            }
        }

        private void txtDec_Leave(object sender, EventArgs e)
        {
            UpdateByteValue();
        }

        private void txtHex_Leave(object sender, EventArgs e)
        {
            UpdateByteValue();
        }

    }
}
