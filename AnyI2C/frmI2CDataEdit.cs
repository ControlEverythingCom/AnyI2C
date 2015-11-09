// 
// ALL RIGHTS RESERVED:
// ====================
// The contents of this file, and associated files in this directory, are 
// Copyright (C) Serial Port Tool(SPT) , all rights reserved, 2015.
// All software Source Code, Images, Database-Design and code, Graphics Design 
// and source files, and related content (collectively referred to as SOURCE) are 
// Copyright (C) SPT, 2015, All Rights Reserved.
// http://SerialPortTool.com
//
// Comm Operator is a Registered Trademark of SerialPortTool.com.

using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using AnyI2C.Data;

namespace AnyI2C.Controls
{
    public partial class frmI2CDataEdit : Form
    {
        I2CData mData = new I2CData();
        public I2CData Data
        {
            get
            {
                return mData;
            }
            set
            {
                mData = value;
            }
        }


        ArrayList ctlBytes = new ArrayList();
        
        public void SetConnectedDevices(byte[] devices)
        {
            ctlI2CAddress1.ConnectedDevices = devices;
            ctlI2CAddress1.UpdateAddressList();
        }

        public frmI2CDataEdit(I2CData data)
        {
            InitializeComponent();
            mData = data;
        }

        private void frmI2CDataEdit_Load(object sender, EventArgs e)
        {
            ctlI2CAddress1.Addr7 = mData.Address;
            UpdateGUIFromData(mData.Content);
            chkWrite.Checked = mData.IsWrite;
            chkRead.Checked = mData.IsRead;
            numReadLength.Value = mData.ReadDataLength;
            txtComment.Text = mData.Comments;
            SetFormat(mData.Format);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            mData.Address = ctlI2CAddress1.Addr7;
            UpdateData();
            mData.IsRead = chkRead.Checked;
            mData.IsWrite = chkWrite.Checked;
            mData.ReadDataLength = (byte)(numReadLength.Value);
            mData.Comments = txtComment.Text;
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void txtQuickSend_TextChanged(object sender, EventArgs e)
        {
            HelpFunction.ValidateResult result = HelpFunction.CheckInput(txtQuickSend.Text, mData.Format);
            if (result.IsValid)
            {
                lbInfo.IsShowText = false;
                lbInfo.Value = new int[] { GetInstanceData().Length };
                lbInfo.ForeColor = Color.Black;
                UpdateBytesControlValue();
            }
            else
            {
                lbInfo.IsShowText = true;
                lbInfo.Text = "Wrong Data";
                lbInfo.ForeColor = Color.Red;
            }

        }

        private void UpdateBytesControlValue()
        {
            byte[] data =GetInstanceData();

            if(ctlBytes.Count > data.Length)
            {
                for(int i = 0; i < ctlBytes.Count - data.Length; i ++)
                {
                    I2C.ctlI2CByte ctl = (I2C.ctlI2CByte)( ctlBytes[i + data.Length]);
                    ctl.OnValueChange -= OnByteCtrlValueChange;
                    panelItems.Controls.Remove(ctl);
                }
                ctlBytes.RemoveRange(data.Length, ctlBytes.Count - data.Length);
            }
            else if(ctlBytes.Count < data.Length)
            {
                int ctlBytesLen = ctlBytes.Count;
                for(int i = 0; i < data.Length - ctlBytesLen; i ++)
                {
                    I2C.ctlI2CByte ctl = new I2C.ctlI2CByte();
                    ctl.Top = (i + ctlBytesLen) * 24 + 17;
                    ctl.Left = 3;
                    ctl.SetID(i + ctlBytesLen);
                    ctl.OnValueChange += new I2C.OnValueChange(OnByteCtrlValueChange);
                    panelItems.Controls.Add(ctl);
                    ctlBytes.Add(ctl);
                }
            }

            for (int i = 0; i < ctlBytes.Count; i++)
            {
                I2C.ctlI2CByte ctl = (I2C.ctlI2CByte)(ctlBytes[i]);
                ctl.Value = data[i];
            }


        }

        private void OnByteCtrlValueChange(object sender, byte v, int id)
        {
            byte[] data = GetInstanceData();
            data[id] = v;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                if (mData.Format == emViewFormat.Dec)
                {
                    sb.Append(string.Format("{0} ", data[i]));
                }
                else
                {
                    sb.Append(string.Format("{0:X2} ", data[i]));
                }
            }
            txtQuickSend.Text = sb.ToString();
        }

        private void cmbShowFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ValidContent)
            {
                cmbShowFormat.SelectedIndexChanged -= cmbShowFormat_SelectedIndexChanged;
                SetFormat(mData.Format);
                cmbShowFormat.SelectedIndexChanged += cmbShowFormat_SelectedIndexChanged;
                return;
            }
            UpdateData();
            mData.Format = GetFormat();
            UpdateGUIFromData(mData.Content);
        }

        /// <summary>
        /// if the input is valid
        /// </summary>
        private bool ValidContent
        {
            get
            {
                bool valid = false;
                try
                {
                    if (txtQuickSend.Text != string.Empty)
                    {
                        if (mData.Format == emViewFormat.Dec)
                        {
                            byte[] data1 = CommonData.GetBytesFromDecString(txtQuickSend.Text);
                        }
                        else
                        {
                            byte[] data1 = CommonData.GetBytesFromHexString(txtQuickSend.Text);
                        }
                        valid = true;
                    }
                    else
                    {
                        valid = true;
                    }


                }
                catch
                {
                    valid = false;
                }
                return valid;
            }
        }

        /// <summary>
        /// get view format from format 
        /// </summary>
        /// <returns></returns>
        private emViewFormat GetFormat()
        {
            if (cmbShowFormat.Text == "HEX")
            {
                return emViewFormat.Hex;
            }
            return emViewFormat.Dec;
        }


        private void SetFormat(emViewFormat format)
        {
            if (format == emViewFormat.Hex)
            {
                cmbShowFormat.SelectedIndex = 0;
            }
            else
            {
                cmbShowFormat.SelectedIndex = 1;
            }

        }


        private byte[] GetInstanceData()
        {
            emViewFormat format = mData.Format;
            string str = txtQuickSend.Text;
            byte[] data = new byte[0];

            switch (format)
            {
                case emViewFormat.Dec:
                    data = CommonData.GetBytesFromDecString(str);
                    break;
                case emViewFormat.Hex:
                    data = CommonData.GetBytesFromHexString(str);
                    break;
                default:
                    break;
            }
            return data;
        }

        private void UpdateData()
        {
            mData.Content = GetDataFromGUI();
            mData.Address = ctlI2CAddress1.Addr7;
        }

        private void UpdateGUIFromData(byte[] content)
        {
            txtQuickSend.Text = "";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < content.Length; i++)
            {
                if (mData.Format == emViewFormat.Dec)
                {
                    sb.Append(string.Format("{0} ", content[i]));
                }
                else
                {
                    sb.Append(string.Format("{0:X2} ", content[i]));
                }
            }
            txtQuickSend.Text = sb.ToString();
        }


        /// <summary>
        /// Create data from gui
        /// </summary>
        /// <returns></returns>
        private byte[] GetDataFromGUI()
        {
            byte addr = (byte)(ctlI2CAddress1.Addr7 * 2);
            byte[] data = CommonData.GetBytes(txtQuickSend.Text, mData.Format, "");
            return data;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //frmCalculator frm = new frmCalculator(mConfig);
            //frm.Data = Data;
            //frm.ShowDialog();
        }
    }
}
