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
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;
using System.IO.Ports;
namespace AnyI2C.Data
{
    /// <summary>
    /// I2c Data represent the data for i2c device
    /// it has extra feature like address, read, write, read data length
    /// address will always be extracted from first byte
    /// </summary>
    public class I2CData : CommonData
    {
        public bool IsWrite = true;
        public bool IsRead = false;
        public byte ReadDataLength = 1;
        public byte mAddress = 0;
        // 7 bit address
        public byte Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }

        public I2CData()
        {
            Format = emViewFormat.Hex;
        }

        /// <summary>
        /// Get address byte value from raw address
        /// </summary>
        /// <returns></returns>
        private byte GetAddressByte(byte addr)
        {
            if (IsWrite)
            {
                return (byte)(addr * 2);
            }
            return (byte)(addr * 2 + 1);
        }

        public override BaseData Copy()
        {
            I2CData data = new I2CData();
            data .IsWrite = IsWrite;
            data .ReadDataLength = ReadDataLength;
            data.Name = Name;
            data.Format = Format;
            data.IsRead = IsRead;
            data.Address = Address;
            if (Content != null)
            {
                data.Content = (byte[])Content.Clone();
            }
            else
            {
                data.Content = null;
            }
            data.Comments = Comments;
            if (WaitInfo != null)
            {
                data.WaitInfo = new WaitInfo(WaitInfo);
            }
            return data;
        }
    }
}
