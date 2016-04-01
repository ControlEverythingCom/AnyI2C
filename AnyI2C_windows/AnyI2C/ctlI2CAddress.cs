using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using AnyI2C;

namespace AnyI2C.Controls.I2C
{
    public partial class ctlI2CAddress : UserControl
    {
        public byte[] ConnectedDevices;
        private byte mAddr8Bits = 0; // 7 bit address
        public byte Addr7
        {
            get
            {
                return (byte)( mAddr8Bits>>1);
            }
            set
            {
                mAddr8Bits = (byte)(value * 2);
                UpdateAddress();
            }
        }

        Label[] BitLabelArray = new Label[8];


        public ctlI2CAddress()
        {
            InitializeComponent();
            BitLabelArray[0] = a0;
            BitLabelArray[1] = a1;
            BitLabelArray[2] = a2;
            BitLabelArray[3] = a3;
            BitLabelArray[4] = a4;
            BitLabelArray[5] = a5;
            BitLabelArray[6] = a6;
            BitLabelArray[7] = a7;
            FillAddressList(null);
        }
        /// <summary>
        /// handle click event on bit label, will toggle the bit value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void a7_Click(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            byte pos = byte.Parse((string)l.Tag);
            byte bitV = ByteLib.GetBit(mAddr8Bits, pos);
            bitV = (byte)((bitV == 0) ? 1 : 0);
            mAddr8Bits = ByteLib.SetBit(mAddr8Bits, pos, bitV);
            UpdateAddress();

        }

        /// <summary>
        /// Update address list, call this after update connecteddevices variable
        /// </summary>
        public void UpdateAddressList()
        {
            FillAddressList(ConnectedDevices);
        }

        private void ctlI2CAddress_Load(object sender, EventArgs e)
        {
            FillAddressList(null);
            UpdateAddress();
            
        }
        private void FillAddressList(byte[] devices)
        {
            ConnectedDevices = devices;
            cmbAddress.Items.Clear();
            if (devices != null)
            {
                for (int i = 0; i < devices.Length; i++)
                {
                    cmbAddress.Items.Add(string.Format("{0} - 0x{0:X2}", devices[i]));
                }
            }
            for (int i = 0; i < 128; i++)
            {
                cmbAddress.Items.Add(string.Format("{0} - 0x{0:X2}", i));
            }
        }

        /// <summary>
        /// Get current selected address
        /// </summary>
        /// <returns></returns>
        private byte GetSelectedAddress()
        {
            int selected = cmbAddress.SelectedIndex;
            byte addr = 0;
            if (ConnectedDevices == null)
            {
                addr = (byte)selected;
            }
            else // has connected device in list
            {
                if (selected < ConnectedDevices.Length)
                {
                    addr = ConnectedDevices[selected];   // get address from list
                }
                else
                {
                    addr = (byte)(selected - ConnectedDevices.Length);
                }
            }
            return addr;
        }


        private void SetAddress(byte addr)
        {
            if (ConnectedDevices != null)
            {
                for (int i = 0; i < ConnectedDevices.Length; i++)
                {
                    if (addr == ConnectedDevices[i])
                    {
                        cmbAddress.SelectedIndex = i;
                        return;
                    }
                }
                cmbAddress.SelectedIndex = addr + ConnectedDevices.Length;

            }
            else
            {
                cmbAddress.SelectedIndex = addr;
            }

        }

        /// <summary>
        /// update bit lables with address value
        /// </summary>
        private void UpdateAddress()
        {
            for (byte i = 0; i < 8; i++)
            {
                byte v = ByteLib.GetBit(mAddr8Bits, i);
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
            //update read/write information
            byte rwBit = ByteLib.GetBit(mAddr8Bits, 0);
            if (rwBit == 0)
            {
                lbRW.Text = "Write";
                lbRW.BackColor = Color.Yellow;
                lb8BitValue.Text = string.Format("W: {0} - 0x{0:X2}", mAddr8Bits);
            }
            else
            {
                lbRW.Text = "Read";
                lbRW.BackColor = Color.LightGreen;
                lb8BitValue.Text = string.Format("R: {0} - 0x{0:X2}  ", mAddr8Bits);
            }
            SetAddress((byte)(mAddr8Bits >> 1));
        }

        private void cmbAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAddress.SelectedIndex != -1)
            {
                byte addr = GetSelectedAddress();
                mAddr8Bits = (byte)((addr << 1) | (mAddr8Bits&0x1));
                UpdateAddress();
            }
        }

    }
}
