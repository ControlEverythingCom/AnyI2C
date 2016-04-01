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
    /// view type
    /// </summary>
    public enum emViewFormat
    {
        Text = 0,
        Hex,
        Dec,
        File,
        ComStatus,
        WaitPeriod,
        WaitTime
    };

    /// <summary>
    /// play status
    /// </summary>
    public enum emPlayStatus
    {
        running,
        pause,
        stop,
    };

    public enum emRegisterStatus
    {
        EXPIRED,
        UNREGISTER,
        REGISTERED,
    };



    /// <summary>
    /// struct: include common send data and time data
    /// </summary>
    public struct ST_SendData
    {
        public DateTime time;   //time
        public CommonData data; //common send data

        public ST_SendData(CommonData _data, int Delay)
        {
            data = _data;
            time = DateTime.Now;
            time = time.AddMilliseconds(Delay);
        }

        public ST_SendData(ST_SendData send)
        {
            time = send.time;
            data = send.data;
        }
    }

    /// <summary>
    /// base data, abstract data
    /// </summary>
    public abstract class BaseData 
    {
        public abstract string[] GetItemStrings();
        /// <summary>
        /// Copy the current
        /// </summary>
        /// <returns></returns>
        public abstract BaseData Copy();
        public string Comments;
    }

//-----------------------------------------------------------------------------
    public struct ST_Symbol
    {
        public bool UseSymbol;	    // wether use symbol
        public bool ShowNothing;	// wether show nothing
        public String Symbol;	    // the string used to show symbol
    }

//-----------------------------------------------------------------------------
    public class AsciiData : BaseData
    {
        public AsciiData()
        {
            Symbol = new ST_Symbol();
        }

        public AsciiData(int index, ST_Symbol sym)
        {
            id = index;
            Symbol = sym;
        }
        /// <summary>
        /// Get list view header string
        /// </summary>
        /// <returns>header string list</returns>
        public static string[] GetHeaderStrings()
        {
            string[] headerStrings = new string[4];

            headerStrings[0] = "No.";
            headerStrings[1] = "Hex";
            headerStrings[2] = "ASCII";
            headerStrings[3] = "Symbol";

            return headerStrings;
        }

        public override BaseData Copy()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// Get default column width
        /// </summary>
        /// <returns></returns>
        public static int[] GetDefaultColumnWidths()
        {
            int[] columnWidths = new int[4];

            columnWidths[0] = 60;
            columnWidths[1] = 100;
            columnWidths[2] = 100;
            columnWidths[3] = 400;

            return columnWidths;
        }

        public override string[] GetItemStrings()
        {
            string[] itemStrings = new string[4];

            itemStrings[0] = id.ToString();

            String hexStr = Convert.ToString(id, 16).ToUpper();
            hexStr = id < 16 ? "0" + hexStr : hexStr;

            itemStrings[1] = hexStr;

            itemStrings[2] = Convert.ToChar(id).ToString();
            itemStrings[3] = (Symbol.UseSymbol && !Symbol.ShowNothing) ? Symbol.Symbol : "";

            return itemStrings;
        }


        public int id = 0;
        public ST_Symbol Symbol;

    }

    public class WaitInfo
    {
        public int WaitPeriod = 1;          // default wait period

        public enum enumPeriodUnit
        {
            MilliSecond,
            Second,
            Minute,
            Hour
        }

        public WaitInfo()
        {

        }

        public WaitInfo(WaitInfo info)
        {
            WaitPeriod = info.WaitPeriod;
            WaitPeriodUnit = info.WaitPeriodUnit;
            WaitToTime = info.WaitToTime;
        }

        public enumPeriodUnit WaitPeriodUnit = enumPeriodUnit.Second;

        public DateTime WaitToTime = DateTime.Now; // defaul wait time

        public double WaitPeriodInMilliSeconds
        {
            get
            {
                long unit = 1;
                switch (WaitPeriodUnit)
                {
                    case enumPeriodUnit.MilliSecond:
                        unit = 1;
                        break;
                    case enumPeriodUnit.Second:
                        unit = 1000;
                        break;
                    case enumPeriodUnit.Minute:
                        unit = 1000 * 60;
                        break;
                    case enumPeriodUnit.Hour:
                        unit = 1000 * 60 * 60;
                        break;
                    default:
                        break;
                }
                return unit * WaitPeriod;
            }
        }

    }


//-----------------------------------------------------------------------------
    /// <summary>
    /// use for send data and edit data
    /// </summary>
    public class CommonData : BaseData
    {
        public CommonData()
        {
            Name = string.Empty;
            Format = emViewFormat.Text;
            Content = new byte[0];
            Comments = string.Empty;
            Filename = string.Empty;
            DTREnable = CheckState.Unchecked;
            RTSEnable = CheckState.Unchecked;
            BreakStatus = CheckState.Unchecked;
        }

        public override BaseData Copy()
        {
            CommonData data = new CommonData();
            data.Name = Name;
            data.Format = Format;
            if (Content != null)
            {
                data.Content = (byte[])Content.Clone();
            }
            else
            {
                data.Content = null;
            }
            data.Filename = Filename;
            data.Comments = Comments;
            if (WaitInfo != null)
            {
                data.WaitInfo = new WaitInfo(WaitInfo);
            }
            data.DTREnable = DTREnable;
            data.RTSEnable = RTSEnable;
            data.BreakStatus = BreakStatus;
            return data;
        }

        /// <summary>
        /// return the length of the data
        /// if data is the file type, return filelength
        /// if data is wait type, return -1
        /// </summary>
        /// <returns></returns>
        public int Length
        {
            get 
            {
                if (Format == emViewFormat.Text
                    || Format == emViewFormat.Dec
                    || Format == emViewFormat.Hex)
                {
                    return Content.Length;
                }

                if (Format == emViewFormat.File)
                {
                    try
                    {
                        FileInfo info = new FileInfo(Filename);
                        return (int)info.Length;
                    }
                    catch (FileNotFoundException ex)
                    {
                        // handle file not find here
                    }
                }
                //for wait type
                return -1;
            }

        }


        /// <summary>
        /// Get list view header string
        /// </summary>
        /// <returns>header string list</returns>
        public static string[] GetHeaderStrings()
        {
            string[] headerStrings = new string[4];

            headerStrings[0] = "Name";
            headerStrings[1] = "Type";
            headerStrings[2] = "Content";
            headerStrings[3] = "Comments";

            return headerStrings;
        }

        /// <summary>
        /// Get default column width
        /// </summary>
        /// <returns></returns>
        public static int[] GetDefaultColumnWidths()
        {
            int[] columnWidths = new int[4];

            columnWidths[0] = 100;
            columnWidths[1] = 100;
            columnWidths[2] = 350;
            columnWidths[3] = 200;

            return columnWidths;
        }

        /// <summary>
        /// Get item strings
        /// </summary>
        /// <returns>item strings</returns>
        public override string [] GetItemStrings()
        {
            string[] itemStrings = new string[4];

            itemStrings[0] = Name;
            itemStrings[1] = Format.ToString();
            switch (Format)
            {
                case emViewFormat.Dec:
                case emViewFormat.Hex:
                case emViewFormat.Text:
                    itemStrings[2] = GetViewString();
                    break;
                case emViewFormat.File:
                    itemStrings[2] = Filename;
                    break;
                case emViewFormat.WaitPeriod:
                case emViewFormat.WaitTime:
                    itemStrings[2] = GetWaitTypeShowString();
                    break;
                case emViewFormat.ComStatus:
                    itemStrings[2] = GetComStatusString();
                    break;
                default:
                    break;
            }
            itemStrings[3] = Comments;
            return itemStrings;
        }

        /// <summary>
        /// Get information string for wait type function
        /// </summary>
        /// <returns></returns>
        private string GetWaitTypeShowString()
        {
            string str = string.Empty;
            if (Format == emViewFormat.WaitTime)
            {
                str = string.Format("Wait to {0}", WaitInfo.WaitToTime.ToShortTimeString());
            }
            else if(Format == emViewFormat.WaitPeriod)
            {
                str = string.Format("Wait for {0} {1}s", WaitInfo.WaitPeriod, WaitInfo.WaitPeriodUnit.ToString());
            }
            return str;
        }

        /// <summary>
        /// Get information for DTR and RTS
        /// </summary>
        /// <returns></returns>
        private string GetComStatusString()
        {
            StringBuilder sb = new StringBuilder();
            if (DTREnable != CheckState.Indeterminate)
            {
                sb.AppendFormat("DTR Enabled = {0}  ", DTREnable == CheckState.Checked);
            }

            if (RTSEnable != CheckState.Indeterminate)
            {
                sb.AppendFormat("RTS Enabled = {0}  ", RTSEnable == CheckState.Checked);
            }

            if (BreakStatus != CheckState.Indeterminate)
            {
                sb.AppendFormat("Break Status = {0}", BreakStatus == CheckState.Checked);
            }
            string str = sb.ToString();
            return str;
        }

        /// <summary>
        /// Get length of content
        /// </summary>
        /// <returns></returns>
        public int GetLength()
        {
            return Content.Length;
        }

        public string Name = string.Empty;     //sometimes is Time in Received data
        
        public emViewFormat Format = emViewFormat.Hex;
        
        //public string ContentStr;
        public byte[] Content = new byte[0];
        
        public string Filename = string.Empty;  // file name, only valid for file type

        public WaitInfo WaitInfo = null;

        public CheckState  DTREnable = CheckState.Unchecked;

        public CheckState RTSEnable = CheckState.Unchecked;

        public CheckState BreakStatus = CheckState.Unchecked;

        /// <summary>
        /// Get bytes from HexString
        /// </summary>
        /// <param name="hexStr"></param>
        /// <returns></returns>
        public static byte[] GetBytesFromHexString(string hexStr)
        {
            ArrayList list = new ArrayList();
            string[] splitStr = HelpFunction.SplitString(hexStr, new char[] { ' ', ',', '\r', '\n', '\t' });
            for (int i = 0; i < splitStr.Length; i++)
            {
                int dec = 0;
                try
                {
                    dec = Convert.ToInt32(splitStr[i], 16);
                }
                catch (Exception exception)
                {
                    throw exception;
                    break;
                }

                if (dec > 255)
                {
                    break;
                }
                list.Add((byte)dec);
            }
            return (byte[])list.ToArray(typeof(byte));
        }

        // this will throw exception if fail to convert
        public static byte[] GetBytesFromDecString(string decStr)
        {
            ArrayList list = new ArrayList();
            string[] splitStr = HelpFunction.SplitString(decStr, new char[] { ' ', ',', '\r', '\n', '\t' });
            for (int i = 0; i < splitStr.Length; i++)
            {
                int dec = 0;
                try
                {
                    dec = Convert.ToInt32(splitStr[i]);
                }
                catch (Exception exception)
                {
                    throw exception;
                    break;
                }
                if (dec > 255)
                {
                    break;
                }
                list.Add((byte)dec);
            }
            return (byte[])list.ToArray(typeof(byte));
        }

        public static byte[] GetBytesFromTextString(string textStr, string cr)
        {
            return HelpFunction.ConvertStringToBytes(textStr, cr);
        }

        public string GetHexString()
        {
            if (Content == null)
            {
                return string.Empty;
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Content.Length; i++)
            {
                sb.AppendFormat("{0:X2} ", Convert.ToInt32(Content[i]));
            }
            return sb.ToString();
        }

        public string GetDecString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Content.Length; i++)
            {
                sb.AppendFormat("{0:D2} ", Convert.ToInt32(Content[i]));
            }
            return sb.ToString();
        }

        public string GetTextString()
        {
            return HelpFunction.ConvertBytesToString(Content);
        }

        public string GetViewString()
        {
            string retStr = string.Empty;
            switch (Format)
            {
                case emViewFormat.Text:
                    retStr = GetTextString();
                    break;
                case emViewFormat.Dec:
                    retStr = GetDecString();
                    break;
                case emViewFormat.Hex:
                    retStr = GetHexString();
                    break;
                case emViewFormat.File:
                    retStr = Filename;
                    break;
                case emViewFormat.WaitPeriod:
                    retStr = GetWaitTypeShowString();
                    break;
                default:
                    break;
            }
            // replace empty string
            string str = retStr.Replace("\0", "");
            return str;
        }

        public static byte[] GetBytes(string str, emViewFormat format)
        {
            byte[] data = null;
            Encoding coding = Encoding.GetEncoding("iso-8859-1");
            switch (format)
            {
                case emViewFormat.Text:
                    data  = coding.GetBytes(str);
                    break;
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



        public static byte[] GetBytes(string str, emViewFormat format, string cr)
        {
            byte[] data = null;
            switch (format)
            {
                case emViewFormat.Text:
                    data = CommonData.GetBytesFromTextString(str, cr);
                    break;
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

        public static string GetViewString(byte[] data, emViewFormat format)
        {
            CommonData cd = new CommonData();
            cd.Content = data;
            cd.Format = format;
            return cd.GetViewString();
        }

    }

//-----------------------------------------------------------------------------

    /// <summary>
    /// use for received data
    /// </summary>
    public class ReceivedData : CommonData
    {
        public ReceivedData()
        {
        }

        /// <summary>
        /// Get list view header string
        /// </summary>
        /// <returns>header string list</returns>
        public static new string[] GetHeaderStrings()
        {
            string[] headerStrings = new string[3];

            headerStrings[0] = "Time";
            headerStrings[1] = "Format";
            headerStrings[2] = "Content";

            return headerStrings;
        }

        /// <summary>
        /// Get default column width
        /// </summary>
        /// <returns></returns>
        public new static int[] GetDefaultColumnWidths()
        {
            int[] columnWidths = new int[3];

            columnWidths[0] = 100;
            columnWidths[1] = 100;
            columnWidths[2] = 400;

            return columnWidths;
        }
    }




//-----------------------------------------------------------------------------
}
