using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Schema;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.IO;



namespace AnyI2C
{

    /// <summary>
    /// Devices collection class search and load all devices in data folder. 
    /// </summary>
    public class DevicesCollection
    {
        const string DataPath = "Data";

        public DeviceConfig[] Devices;
        public DevicesCollection()
        {

        }

        /// <summary>
        /// search and load devices configure
        /// </summary>
        public void LoadAllDevices()
        {
            ArrayList devices = new ArrayList();
            if (Directory.Exists(DataPath))
            {
                var files = Directory.EnumerateFiles(DataPath, "*.xml");
                foreach (var d in files)
                {
                    Debug.Print(d.ToString());
                    DeviceConfig dev = new DeviceConfig();
                    dev.Load(d.ToString());
                    devices.Add(dev);
                }
            }
            Devices = (DeviceConfig[])devices.ToArray(typeof(DeviceConfig));
        }

        /// <summary>
        /// load all devices in data folder
        /// </summary>
        /// <returns></returns>
        public bool Load()
        {
            try
            {
                DeviceConfig config = new DeviceConfig();
                config.Load("Temp.xml");
                config.Commands = new DeviceCommandsGroup();
                config.Commands.Name = "Init";
                config.Commands.Description = "Initial device";
                config.Commands.Commands = new DeviceCommand[1];
                DeviceCommand cmd = new DeviceCommand();
                config.Commands.Commands[0] = cmd;
                config.Commands.Commands[0].Name = "test";
                config.Commands.Commands[0].Description = "test des";
                cmd.Data = new byte[] { 22, 33 };
                cmd.ReadDataLength = 2;
                config.Save("test.xml");
                //DeviceConfig.SaveAsTemp();
            }
            catch (Exception e)
            {
                Debug.Print("Fail to load configure file.");
            }
            return false;
        }

        /// <summary>
        /// save all devices in data folder
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            try
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.IndentChars = "\t";
                settings.OmitXmlDeclaration = true;     //omit declaration
                settings.NewLineOnAttributes = true;
                XmlWriter writer = XmlWriter.Create("Config.xml", settings);
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add(String.Empty, String.Empty);
                XmlSerializer serializer = new XmlSerializer(typeof(Configure));
                serializer.Serialize(writer, this, ns);
                writer.Flush();
                writer.Close();
            }
            catch (Exception e)
            {
                Debug.Print("Fail to save configure file.");
            }
            return false;
        }
    }

    /// <summary>
    /// DeviceConfig is the class that configure
    /// </summary>
    public class DeviceConfig
    {
        public string Type;
        public string path;
        public string Name;
        public string Manufactory;
        public bool GeneralCall = true; // if support general call
        public byte Address;
        [XmlArrayItem("Address") ]
        public byte[] AddressCollection;
        public DeviceCommandsGroup Commands;
        public bool Load(string filename)
        {
            try
            {
                XmlReader reader = XmlReader.Create(filename);
                XmlSerializer serializer = new XmlSerializer(typeof(DeviceConfig));
                DeviceConfig temp = (DeviceConfig)serializer.Deserialize(reader);
                Type = temp.Type;
                path = filename;
                Name = temp.Name;
                Manufactory = temp.Manufactory;
                GeneralCall = temp.GeneralCall;
                Address = temp.Address;
                AddressCollection = temp.AddressCollection;
                Commands = temp.Commands;

                reader.Close();
            }
            catch (Exception e)
            {
                Debug.Print("Fail to load configure file.");
            }
            return false;
        }

        public bool Save(string filename)
        {
            try
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.IndentChars = "\t";
                settings.OmitXmlDeclaration = true;     //omit declaration
                settings.NewLineOnAttributes = true;
                XmlWriter writer = XmlWriter.Create(filename, settings);
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add(String.Empty, String.Empty);
                XmlSerializer serializer = new XmlSerializer(typeof(DeviceConfig));
                serializer.Serialize(writer, this, ns);  
                writer.Flush();
                writer.Close();
            }
            catch (Exception e)
            {
                Debug.Print("Fail to save configure file.");
            }
            return false;
        }

        static public void SaveAsTemp(string filename)
        {
            DeviceConfig config = new DeviceConfig();
            config.Name = "DemoI2C";
            config.path = filename;
            config.Type = "AD";
            config.Manufactory = "HoneyWell";
            config.Address = 22;
            config.AddressCollection = new byte[] { 22, 33 };
            config.Commands = new DeviceCommandsGroup();
            config.Save(filename);
        }

    }


    /// <summary>
    /// this is device command
    /// </summary>
    public class DeviceCommandBase
    {
        public string Name;
        public string Description;

    }

    /// <summary>
    /// Command set
    /// </summary>
    public class DeviceCommandsGroup : DeviceCommandBase 
    {
        [XmlElement (Type = typeof(DeviceCommandsGroup)),
            XmlElement (Type = typeof(DeviceCommand)),
            XmlElement(Type = typeof(DeviceGUICommand)),
            ]
        public DeviceCommandBase[] Commands;
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} : ", Name);
            sb.Append(Description);
            return sb.ToString();
        }

    }

    public class DeviceCommand : DeviceCommandBase
    {
        [XmlArrayItem("Value")]
        public byte[] Data;
        public byte ReadDataLength = 0;
        public bool Write = true;

        public string GetSendDataString(bool hex)
        {
            StringBuilder sb = new StringBuilder();
            if (Data != null)
            {
                for (int i = 0; i < Data.Length; i++)
                {
                    if (hex)
                    {
                        sb.AppendFormat("{0:X2} ", Data[i]);
                    }
                    else
                    {
                        sb.AppendFormat("{0} ", Data[i]);
                    }
                }
            }
            return sb.ToString();
        }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} [ ", Name);
            if (Data != null)
            {
                for (int i = 0; i < Data.Length; i++)
                {
                    sb.AppendFormat("{0:X2} ", Data[i]);
                }
            }
            sb.Append(" ] ");
            sb.Append(Description);
            return sb.ToString();
        }
    }
    public class DeviceGUICommand : DeviceCommandBase
    {
        public string GUIPath;// path of GUI module
        public string TypeName; // type of GUI module
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} -{1} ", Name, Description);
            sb.Append(Description);
            return sb.ToString();
        }
    }


}
