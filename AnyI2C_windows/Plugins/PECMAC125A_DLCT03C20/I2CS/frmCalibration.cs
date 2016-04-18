using System;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using AnyI2C;

namespace CurrentMonitor_I2CS
{
    public partial class frmCalibration : Form
    {
        public CommInterface CommObj = null;
        public byte ChannelsCount = 12;
        public byte Address = 0;
        private ArrayList TxtArray;
        private ArrayList LabelArray;
        public frmCalibration()
        {
            InitializeComponent();
        }

        /// <summary>
        /// load data from board
        /// </summary>
        private void LoadData()
        {
            try
            {
                //read the  the sensor
                byte[] temp = new byte[] { 0x92, 0x6A, 0x03, 1, ChannelsCount, 0x00, 0x00 };
                byte checksum = GetCheckSum(temp);
                byte[] value = CommObj.Send(new byte[] { Address, 0x92, 0x6A, 0x03, 0x01, ChannelsCount, 0x00, 0x00, checksum}, (byte)(ChannelsCount * 2 + 1));
                Thread.Sleep(100);
                if (value != null)
                {
                    if (value.Length == ChannelsCount * 2 + 1)
                    {
                        for (int i = 0; i < ChannelsCount; i++)
                        {
                            TextBox msb = (TextBox)(TxtArray[i * 2]);
                            TextBox lsb = (TextBox)(TxtArray[i * 2 + 1]);
                            msb.Text = value[i * 2].ToString();
                            lsb.Text = value[i * 2 + 1].ToString();
                            Label lb = (Label)(LabelArray[i]);
                            lb.Text = (value[i * 2] * 256 + value[i * 2 + 1]).ToString();
                        }
                    }
                }
            }
            catch
            {
            }
        }

        /// <summary>
        /// save data to board
        /// </summary>
        private void SaveData()
        {
            try
            {
                for (int i = 0; i < ChannelsCount; i++)
                {
                    //read the  the sensor
                    TextBox msbText = (TextBox)(TxtArray[i * 2]);
                    TextBox lsbText = (TextBox)(TxtArray[i * 2 + 1]);
                    byte msb = byte.Parse(msbText.Text);
                    byte lsb = byte.Parse(lsbText.Text);
                    byte[] temp = new byte[] { 0x92, 0x6A, 0x04, (byte)(i + 1), (byte)(i + 1), msb, lsb};
                    byte checksum = GetCheckSum(temp);
                    byte[] value = CommObj.Send(new byte[] { Address, 0x92, 0x6A, 0x04, (byte)(i + 1), (byte)(i + 1), msb, lsb, checksum }, 0);
                    Thread.Sleep(100);

                }
            }
            catch
            {
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();

        }

        /// <summary>
        /// Calculate the check sum
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private byte GetCheckSum(byte[] data)
        {
            int checksum = 0;
            for (int i = 0; i < data.Length; i++)
            {
                checksum += data[i];
            }
            return (byte)(checksum & 0xff);
        }


        private void frmCalibration_Load(object sender, EventArgs e)
        {
            // add controls to array
            TxtArray = new ArrayList();
            TxtArray.Add(txtCh1Msb);
            TxtArray.Add(txtCh1Lsb);

            TxtArray.Add(txtCh2Msb);
            TxtArray.Add(txtCh2Lsb);

            TxtArray.Add(txtCh3Msb);
            TxtArray.Add(txtCh3Lsb);

            TxtArray.Add(txtCh4Msb);
            TxtArray.Add(txtCh4Lsb);

            TxtArray.Add(txtCh5Msb);
            TxtArray.Add(txtCh5Lsb);

            TxtArray.Add(txtCh6Msb);
            TxtArray.Add(txtCh6Lsb);

            TxtArray.Add(txtCh7Msb);
            TxtArray.Add(txtCh7Lsb);

            TxtArray.Add(txtCh8Msb);
            TxtArray.Add(txtCh8Lsb);

            TxtArray.Add(txtCh9Msb);
            TxtArray.Add(txtCh9Lsb);

            TxtArray.Add(txtCh10Msb);
            TxtArray.Add(txtCh10Lsb);

            TxtArray.Add(txtCh11Msb);
            TxtArray.Add(txtCh11Lsb);

            TxtArray.Add(txtCh12Msb);
            TxtArray.Add(txtCh12Lsb);

            LabelArray = new ArrayList();
            LabelArray.Add(lbV1);
            LabelArray.Add(lbV2);
            LabelArray.Add(lbV3);
            LabelArray.Add(lbV4);
            LabelArray.Add(lbV5);
            LabelArray.Add(lbV6);
            LabelArray.Add(lbV7);
            LabelArray.Add(lbV8);
            LabelArray.Add(lbV9);
            LabelArray.Add(lbV10);
            LabelArray.Add(lbV11);
            LabelArray.Add(lbV12);

            //setup controls' status
            for (int i = 0; i < 12; i++)
            {
                TextBox txt1 = (TextBox)TxtArray[i * 2];
                TextBox txt2 = (TextBox)TxtArray[i * 2 + 1];
                if (i < ChannelsCount)
                {
                    txt1.Enabled = true;
                    txt2.Enabled = true;
                    
                }
                else
                {
                    txt1.Enabled = false;
                    txt2.Enabled = false;
                }

            }
        }
    }
}
