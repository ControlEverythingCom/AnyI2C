
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Reflection;
using Microsoft.Win32;
using System.Diagnostics;


namespace AnyI2cLib
{
    // All method used for mutlipla classes are implement here as static method
    public class HelpFunction
    {
        public const int MinPeriodOfSending = 5;   // minium time between sending data, in seconds
        public const int TemporaryTime = 120;         // the period for temporary status. it will go to timerId status after this time. in minutes

        public const string RootPath = "\\Config\\";
        public const string BoardPath = RootPath + "Board";
        public const string ScheduleFilename = "schedule.cfg";
        public const string StatusFilename = "status.ptn";
        public const string BoardInfoFilename = "BoardInfo.xml";

        public const string IPAddress = "127.0.0.1";
        public const int PortNumber = 13000;

        public static Mutex NcdControlLocker = new Mutex();


        /// <summary>
        /// Get the AppExe path
        /// </summary>
        /// <returns></returns>
        public static string GetAppExePath()
        {
            Assembly app = Assembly.GetEntryAssembly();

            return app.Location;
        }


        /// <summary>
        /// Get path of RelayTimer.exe
        /// </summary>
        /// <returns></returns>
        public static string GetTimerExePath()
        {
            string path;
            string appPath = GetAppExePath();
            DirectoryInfo source = new DirectoryInfo(appPath);
            path = source.Parent.FullName;
            path = string.Concat(path, "\\RelayTimer.exe");
            return path;
        }

        /// <summary>
        /// Get the path of the board information file
        /// </summary>
        /// <returns></returns>
        /// 
        public static string GetPathOfConfiguration()
        {
            // load configuration file from command line first
            string path = GetCommandLineConfiguration();
            if (path != string.Empty)
            {
                return path;
            }
            return GetDefaultConfiguration();
        }


        /// <summary>
        /// Get the configuration file from Command Line,
        /// </summary>
        /// <returns></returns>
        private static string GetCommandLineConfiguration()
        {
            string path = string.Empty;
            string[] strs = Environment.GetCommandLineArgs();
            if (strs.Length > 1)
            {
                for (int i = 0; i < strs.Length - 1; i++)
                {
                    if (strs[i] == "-c" || strs[i] == "-C")
                    {
                        path = strs[i + 1];
                    }
                }
            }
            return path;
        }

        /// <summary>
        /// Get the default Configuration file
        /// </summary>
        /// <returns></returns>
        public static string GetDefaultConfiguration()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            //path = string.Concat(path, "\\Serial Port Tool\\" + ProductInfo.ApplicationName);
            //Directory.CreateDirectory(path);    // Create directory if not exists.

            //path = string.Concat(path, "\\" + ProductInfo.CONFIG_FILE);
            return path;
        }

        /// <summary>
        /// Get the path of file
        /// </summary>
        /// <param mName="filename">boardId of the board, 1 for the first one</param>
        /// <returns></returns>
        public static string GetPathOfFile(int id, string filename)
        {
            string path;
            string MyPath = GetAppExePath();
            DirectoryInfo source = new DirectoryInfo(MyPath);
            path = source.Parent.FullName;
            path = string.Concat(path, BoardPath);
            path = path + (id).ToString();
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            path = string.Concat(path, "\\");
            path = string.Concat(path, filename);
            return path;
        }

        /// <summary>
        /// Get the board schedule file mName
        /// </summary>
        /// <param mName="boardId">boardId of the board, 1 for the first one</param>
        /// <returns></returns>
        public static string GetScheduleFilename(int id)
        {
            return GetPathOfFile(id, ScheduleFilename);
        }

        /// <summary>
        /// Get the board status file mName
        /// </summary>
        /// <param mName="boardId">boardId of the board, 1 for the first one</param>
        /// <returns></returns>
        public static string GetStatusFilename(int id)
        {
            return GetPathOfFile(id, StatusFilename);
        }


        

        /// <summary>
        /// this function will get build No from assembly version
        /// </summary>
        /// <returns></returns>
        public static string GetBuildVersion()
        {
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(GetAppExePath());

            return string.Format("Version {0}.{1}.{2}", versionInfo.FileMajorPart, versionInfo.FileMinorPart, versionInfo.FileBuildPart);

        }

    }


    /// <summary>
    /// Utility.
    /// </summary>
    public class Util
    {
        private const string RUN_LOCATION = @"Software\Microsoft\Windows\CurrentVersion\Run";

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

        /// <summary>
        /// return the new value with specific bit set
        /// </summary>
        /// <param name="v"></param>
        /// <param name="pos"></param>
        /// <param name="bitValue"></param>
        /// <returns></returns>
        static public byte SetBit(byte v, byte pos, bool bitValue)
        {
            return SetBit(v, pos, (byte)(bitValue ? 1 : 0));
        }

        public enum emCheckSumMethod
        {
            CS_A_B = 0                  // check sum by plus all bytes together and mod with 0x100
            ,
            CS_FF_A_B             // check sum by 0xFF minus value in CS_A_B, like zig bee device
          , CS_100_A_B            // check sum by 0x100 minus value in CS_A_B
        }


        /// <summary>
        /// calculate the value of checksum
        /// </summary>
        /// <param name="data">data to checksum</param>
        /// <returns>value of checksum</returns>
        static public byte CheckSum(byte[] data, emCheckSumMethod method)
        {
            byte checksum = 0;
            switch (method)
            {
                case emCheckSumMethod.CS_A_B:
                    checksum = CheckSum_A_B(data);
                    break;
                case emCheckSumMethod.CS_FF_A_B:
                    checksum = CheckSum_FF_A_B(data);
                    break;
                case emCheckSumMethod.CS_100_A_B:
                    checksum = CheckSum_100_A_B(data);
                    break;
                default:
                    throw new NotImplementedException("Check Sum method error");

            }
            return (byte)checksum;
        }



        /// <summary>
        /// calculate the value of checksum
        /// </summary>
        /// <param name="data">data to checksum</param>
        /// <returns>value of checksum</returns>
        static public byte CheckSum_FF_A_B(byte[] data)
        {
            int checksum = 0;
            for (int i = 0; i < data.Length; i++)
            {
                checksum += data[i];
            }
            checksum = checksum % 0x100;
            checksum = 0xFF - checksum;
            return (byte)checksum;
        }

        /// <summary>
        /// calculate the value of checksum
        /// </summary>
        /// <param name="data">data to checksum</param>
        /// <returns>value of checksum</returns>
        static public byte CheckSum_100_A_B(byte[] data)
        {
            int checksum = 0;
            for (int i = 0; i < data.Length; i++)
            {
                checksum += data[i];
            }
            checksum = checksum % 0x100;
            checksum = 0x100 - checksum;
            return (byte)checksum;
        }

        /// <summary>
        /// calculate the value of checksum
        /// </summary>
        /// <param name="data">data to checksum</param>
        /// <returns>value of checksum</returns>
        static public byte CheckSum_A_B(byte[] data)
        {
            int checksum = 0;
            for (int i = 0; i < data.Length; i++)
            {
                checksum += data[i];
            }
            checksum = checksum % 0x100;
            return (byte)checksum;
        }

        /// <summary>
        /// Dump all content of byte array, will also return a string
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="data"></param>
        static public string DumpByteArray(string msg, params byte[] data)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(msg);
            if (msg != string.Empty)
            {
                sb.Append(":");
            }
            if (data != null)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    sb.AppendFormat("{0:X2} ", data[i]);
                }
            }
            else
            {
                sb.Append("Null Array");
            }
            Debug.Print(sb.ToString());
            return sb.ToString();

        }

    }
}