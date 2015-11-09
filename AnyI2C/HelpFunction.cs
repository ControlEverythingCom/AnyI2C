
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.IO.Ports;
using AnyI2C;
using AnyI2C.Data;
using System.Globalization;
using Microsoft.Win32;
using System.Diagnostics;

using System.Net;
using System.Net.NetworkInformation;

namespace AnyI2C
{
    public class ConstDef
    {
        public const string WrongInputMessage = "Wrong input data, please correct the selected text.";
    }


    public class HelpFunction
    {
        private static string defaultSymbolFileName             = "Default.sym";
        private static string defaultPortSettingFileName        = "Default.cps";

        private static string defaultAutoSendFileName           = "Default.ass";
        private static string defaultRecDataListFileName        = "Default.rds";
        private static string defaultConfigFileName             = "I2CConfig";


        /// <summary>
        /// Get default port setting file path
        /// </summary>
        /// <returns></returns>
        public static string GetDefaultPortSettingFilePath()
        {
            string locationPath = GetPathOfUserData();
            return locationPath + "\\" + defaultPortSettingFileName;
        }

        /// <summary>
        /// Get default Config file path
        /// </summary>
        /// <returns></returns>
        public static string GetDefaultConfigFilePath()
        {
            string locationPath = GetPathOfUserData();
            return locationPath + "\\" + defaultConfigFileName;
        }

        /// <summary>
        /// Get default received data list file path
        /// </summary>
        /// <returns></returns>
        public static string GetDefaultRecvDataListFilePath()
        {
            string locationPath = GetPathOfUserData();
            return locationPath + "\\" + defaultRecDataListFileName;
        }


       /// <summary>
        /// Get default auto send data file path
        /// </summary>
        /// <returns></returns>
        public static string GetDefaultAutoSendFilePath()
        {
            string locationPath = GetPathOfUserData();
            return locationPath + "\\" + defaultAutoSendFileName;
        }

        /// <summary>
        /// Get default symbol data file path
        /// </summary>
        /// <returns></returns>
        public static string GetDefaultSymbolFilePath()
        {
            string locationPath = GetPathOfUserData();
            return locationPath + "\\" + defaultSymbolFileName;
        }

        /// <summary>
        /// Get Default log file folder
        /// It shoudl be in mydocuments\CommOp\LogFiles
        /// </summary>
        /// <returns></returns>
        public static string GetDefaultLogFolder()
        {
            string logfolder = GetPathOfUserData();
            return logfolder + "\\LogFiles";
        }


        
        /// <summary>
        /// get the default data folder, it should be in \my document\CommOp
        /// </summary>
        /// <returns></returns>
        public static string GetPathOfUserData()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path = string.Concat(path, "\\AnyI2C");
            Directory.CreateDirectory(path);    // Create directory if not exists.
            return path;
        }


        public static string GetAppExePath()
        {
            Assembly app = Assembly.GetEntryAssembly();

            return app.Location;

        }

        /// <summary>
        /// Get current exe path
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentPath()
        {
            Assembly app = Assembly.GetExecutingAssembly();
            string locationPath = Path.GetDirectoryName(app.ManifestModule.FullyQualifiedName);
            return locationPath;
        }

        /// <summary>
        /// enum parse. get enum object from string
        /// </summary>
        /// <param name="enumType">enum type</param>
        /// <param name="str"></param>
        /// <returns></returns>
        public static object EnumParse(Type enumType, string str)
        {
            return Enum.Parse(enumType, str,false);

        }


        /// <summary>
        /// Get single selected ID of listview
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static int GetSingleSelectId(ListView list)
        {
            return list.SelectedIndices.Count > 0 ? list.SelectedIndices[0] : -1;
        }


        /// <summary>
        /// Convert string like " Hex,"Hello world" " to CommonData.
        /// data.Name = "Send Data", data.Format = Hex, data.Content = Hello world
        /// </summary>
        /// <param name="str">string always read from files</param>
        /// <returns></returns>
        public static CommonData ConvertStringToCommonData(string str)
        {
            CommonData sendData = new CommonData();
            if (str == null || str.Length == 0)
            {
                return sendData;
            }
            sendData.Name = "Send Data";
            string[] typeString = HelpFunction.SplitString(str, new char[] { ',' });
            sendData.Format = (emViewFormat)Enum.Parse(typeof(emViewFormat), typeString[0],false);
            int firstLetter = str.IndexOf('"') + 1;
            string hexStr = str.Substring(firstLetter, str.Length - firstLetter - 1);
            sendData.Content = CommonData.GetBytesFromHexString(hexStr);
            return sendData;
        }

        /// <summary>
        /// convert time string to DateTime. timestring format like "11:11:11.000"
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static DateTime ConvertStringToDateTime(string str)
        {
            //11:11:11.11
            str = str.Length < 11 ?  str.PadRight(11, '0') : str;
            DateTime time = DateTime.Today;
            string[] splitStr = HelpFunction.SplitString(str, new char[] { '.' });  //"11:11:11" & "000"

            int milliSecond = (splitStr[1].Length > 0) ? Convert.ToInt16(splitStr[1]) : Convert.ToInt16(0);
            time = time.AddMilliseconds(milliSecond);           //add milliseconds
            string timeStr = splitStr[0].Replace(' ', '0');  //" 1:1 :11" -> "01:10:11"

            splitStr = HelpFunction.SplitString(timeStr, new char[] { ':' });
            time = time.AddHours(Convert.ToInt32(splitStr[0]));     //add hours
            time = time.AddMinutes(Convert.ToInt32(splitStr[1]));   //add minutes
            time = time.AddSeconds(Convert.ToInt32(splitStr[2]));   //add seconds
            //time = Convert.ToDateTime(timeStr);
            
            return time;
        }



        /// <summary>
        /// Structure for validate result
        /// </summary>
        public struct ValidateResult
        {
            public ValidateResult(bool isValid, int nStartPosition, int nLength)
            {
                IsValid = isValid;
                StartPosition = nStartPosition;
                Length = nLength;
            }
            public bool IsValid;       // flag for if the content is valid
            public int StartPosition;  // Start position of the first string that failed to check, will be ignored if valid
            public int Length;         // length of the first string that failed to check.

            /// <summary>
            /// For help function
            /// </summary>
            /// <returns></returns>
            public string Dump()
            {
                string str = string.Format("IsValid {0} Start{1} Len{2}", IsValid, StartPosition, Length);
                return str;
            }


        }

        /// <summary>
        /// Test if the str is valid to convert to certain type
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool ValidString(string str, emViewFormat type)
        {
            try
            {
                byte n = 0;
                int formBase = 10;
                switch (type)
                {
                    case emViewFormat.Dec:
                        formBase = 10;
                        break;
                    case emViewFormat.Hex:
                        formBase = 16;
                        break;
                    default:
                        throw new NotImplementedException();
                }
                n = System.Convert.ToByte(str, formBase);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public static ValidateResult CheckInput(string str, emViewFormat type)
        {
            ValidateResult result = new ValidateResult(true, 0, 0);
            if (type == emViewFormat.Text)
            {
                return result;
            }

            if (type == emViewFormat.File)
            {
                return result;
            }

            if (type == emViewFormat.ComStatus)
            {
                return result;
            }

            if (type == emViewFormat.WaitPeriod || type == emViewFormat.WaitTime) 
            {
                return result;
            }



            char[] dilimer = new char[] { ' ', ',', '\r', '\n', '\t' };
            string[] strs = HelpFunction.SplitString(str, dilimer);
            for (int i = 0; i < strs.Length; i++)
            {

                System.Diagnostics.Debug.WriteLine(strs[i]);
                bool bValid = ValidString(strs[i],type);
                if (!bValid)
                {
                    result.IsValid = bValid;
                    result.StartPosition = str.IndexOf(strs[i]);
                    result.Length = strs[i].Length;
                    break;
                }
            }
            return result;
        }


    
        public static Encoding GetISO8859Encoding()
        {
            return Encoding.GetEncoding("iso-8859-1");
        }

        /// <summary>
        /// Convert string to iso-8859-1 byte array
        /// it will replace the carriage return with the value in options
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static Byte[] ConvertStringToBytes(string str,string cr)
        {
            // normalize string, to make it have "\r" only
            str = str.Replace("\r\n", "\r");
            str = str.Replace("\n", "\r");

            // replace the return with options's setting
            str = str.Replace("\r", cr);

            Encoding coding = Encoding.GetEncoding("iso-8859-1");
            return coding.GetBytes(str);
        }


        /// <summary>
        /// Convert string to iso-8859-1 byte array
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string ConvertBytesToString(Byte[] bytes)
        {
            if (bytes == null)
            {
                return string.Empty;
            }
            Encoding coding = Encoding.GetEncoding("iso-8859-1");
            return coding.GetString(bytes, 0, bytes.Length);
        }

        /// <summary>
        /// Split string according the dilimer, this function is equea to 
        /// String.Split(char[], StringSplitOptions.RemoveEmptyEntries)
        /// which is not supported by .net cf
        /// </summary>
        /// <param name="splitStr"></param>
        /// <returns></returns>
        public static string[] SplitString(string str, char[] separator)
        {
            string[] splitStr = str.Split(separator);
            System.Collections.ArrayList list = new System.Collections.ArrayList();
            for (int i = 0; i < splitStr.Length; i++)
            {
                if (splitStr[i] != string.Empty && splitStr[i] != null)
                {
                    list.Add(splitStr[i]);
                }
            }
            splitStr = new string[list.Count];
            list.CopyTo(splitStr);
            return splitStr;
        }

        /// <summary>
        /// Format time to string like 00:00:00
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static string TimeToStringLong(DateTime time)
        {
            string str = time.ToString("HH:mm:ss");
            str = str + "." + time.Millisecond.ToString("D3");  //"00:00:00.000"
            return str;
        }
        
        /// <summary>
        /// this function will get build No from assembly version
        /// </summary>
        /// <returns></returns>
        public static string GetBuildVersion()
        {
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(GetAppExePath());
            string version = "v " + versionInfo.FileVersion;
            return version;
        }

        /// <summary>
        /// Get relative path
        /// </summary>
        /// <param name="rootPath">indicates root path</param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string GetRelativePath(string rootPath, string path)
        {
            if (!rootPath.EndsWith("\\")) rootPath += "\\";

            int intIndex = -1, intPos = rootPath.IndexOf('\\');
            while (intPos >= 0)
            {
                intPos++;
                if (string.Compare(rootPath, 0, path, 0, intPos, true) != 0)

                    break;
                intIndex = intPos;
                intPos = rootPath.IndexOf('\\', intPos);
            }

            if (intIndex >= 0)
            {
                path = path.Substring(intIndex);
                intPos = rootPath.IndexOf("\\", intIndex);
                while (intPos >= 0)
                {
                    path = "..\\" + path;
                    intPos = rootPath.IndexOf("\\", intPos + 1);
                }
            }
            return path;
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
            CS_A_B  = 0                  // check sum by plus all bytes together and mod with 0x100
            , CS_FF_A_B             // check sum by 0xFF minus value in CS_A_B, like zig bee device
            , CS_100_A_B            // check sum by 0x100 minus value in CS_A_B
            , FLETCHER              // Fletcher's Checksum
            , XOR                   // xor
            , CRC16Standard         // CRC 16 standard = 0xA001
            , CRC16CCITT            // CRC 16 CCITT Kermit = 0x8408   
            , CS_FF_OR              // check by 0xFF or all bytes together

        }

    }

}
