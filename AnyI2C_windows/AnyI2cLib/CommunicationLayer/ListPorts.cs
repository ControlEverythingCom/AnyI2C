
using System;
using System.Collections;
using System.Management;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Diagnostics;
using System.IO.Ports;

namespace AnyI2cLib.Data
{
    /// <summary>
    /// ListPorts class is used to get information from ListPorts.exe
    /// </summary>
    public class ListPorts
    {
        public SerialDeviceInfo[] Infos;
        public static SerialDeviceInfo[] EnumPorts()
        {
            try
            {

                ArrayList list = new ArrayList();
                ManagementObjectSearcher searcher =

                                new ManagementObjectSearcher("root\\CIMV2",

                                "SELECT * FROM Win32_PnPEntity");

                if (searcher != null)
                {
                    foreach (ManagementObject queryObj in searcher.Get())
                    {
                        object obj = queryObj["Caption"];
                        if (obj != null)
                        {
                            if (obj.ToString().Contains("(COM"))
                            {
                                SerialDeviceInfo deviceInfo;
                                deviceInfo.FriendName = obj.ToString();
                                deviceInfo.PortName = FindComPortString(deviceInfo.FriendName);
                                list.Add(deviceInfo);
                            }

                        }

                    }
                    return (SerialDeviceInfo[])list.ToArray(typeof(SerialDeviceInfo));

                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
            return null;

        }


        /// <summary>
        /// finid the com port string 
        /// </summary>
        /// <param name="des"></param>
        /// <returns></returns>
        static string FindComPortString(string des)
        {
            int n1 = des.LastIndexOf('(');
            int n2 = des.LastIndexOf(')');
            return des.Substring(n1 + 1, n2 - n1 - 1);
        }


    }

    /// <summary>
    /// structure for serial port device, include serial port and modem
    /// </summary>
    public struct SerialDeviceInfo
    {
        public string FriendName;
        public string PortName;

    }
}