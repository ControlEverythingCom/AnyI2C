

using System;
using System.Collections;
using System.Text;
using System.Threading;
using System.IO.Ports;


namespace AnyI2cLib
{
    public delegate void UpdateMessageHandler(string err);


    public class NetworkConfig
    {
        public string IPAddress = "192.168.0.104";
        public int NetworkPort = 2101;      // default port number is 2000
        public int UdpPort = 3333;          // udp broadcase port
        public string Mac = "";             // mac address
        public bool Wifi = true;
        public bool UsingTCP = false;       // for push notification network only

        public NetworkConfig Clone()
        {
            NetworkConfig nc = new NetworkConfig();
            nc.IPAddress = IPAddress;
            nc.NetworkPort = NetworkPort;
            nc.UdpPort = UdpPort;
            nc.Mac = Mac;
            nc.Wifi = Wifi;
            nc.UsingTCP = UsingTCP;
            return nc;
        }
    }

    /// <summary>
    /// use for port data
    /// </summary>
    public class PortData
    {

        public PortData()   //default setting
        {
            string[] ports = SerialPort.GetPortNames();
            portName = ports.Length > 0 ? ports[0] : String.Empty;  //get first valid port name
            baudRate = 115200;
            readTimeout = 30;
            StopBits = StopBits.One;
            Parity = System.IO.Ports.Parity.None;
        }

        /// <summary>
        /// construct portData object with specified port name
        /// </summary>
        /// <param name="name">specified port name</param>
        public PortData(string name)
        {
            portName = name;
            baudRate = 115200;
            readTimeout = 30;
            StopBits = StopBits.One;
            Parity = System.IO.Ports.Parity.None;
        }

        public PortData Clone()
        {
            PortData p = new PortData();
            p.baudRate = baudRate;
            p.Parity = Parity;
            p.portName = portName;
            p.readTimeout = readTimeout;
            p.StopBits = StopBits;
            return p;
        }

        public string portName; //port name
        public int baudRate; //baud rate
        public int readTimeout;
        public StopBits StopBits;
        public Parity Parity;

    }

    public class ConnectionException : Exception
    {
        string mMessage;
        public ConnectionException(string msg)
        {
            mMessage = msg;
        }

        public override string Message
        {
            get
            {
                return mMessage;
            }
        }
    }

    public abstract class CommBaseObj
    {
        public event UpdateMessageHandler OnConnectStatusChange;

        protected void _OnConnectStatusChange(string str)
        {
            OnConnectStatusChange?.Invoke(str);
        }
    

        /// <summary>
        /// property for if the device is open
        /// </summary>
        public abstract bool IsOpen
        {
            get;
        }

        public abstract int ReadTimeOut
        {
            get;

            set;
        }

        public virtual void WaitOne()
        {

        }

        public virtual void ReleaseOne()
        {

        }
        /// <summary>
        /// Property for Connection Infomation
        /// </summary>
        public abstract string ConnectionInfo
        {
            get;
        }

        /// <summary>
        /// discard all data in input buffer
        /// </summary>
        public abstract void Purge();

        /// <summary>
        /// Open device
        /// </summary>
        /// <returns></returns>
        public abstract void Open();

        /// <summary>
        /// Close device
        /// </summary>
        /// <returns></returns>
        public abstract void Close();

        /// <summary>
        /// Write a byte 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public void WriteByte(byte data)
        {
            WriteBytes(data);
        }

        /// <summary>
        /// Write bytes array 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public abstract void WriteBytes(params byte[] data);

        /// <summary>
        /// Read a byte, return -1 if failure
        /// </summary>
        /// <returns></returns>
        public abstract byte ReadByte();

        /// <summary>
        /// Read all bytes
        /// </summary>
        /// <returns></returns>
        public abstract byte[] ReadAll();
        /// <summary>
        /// Sleep function
        /// </summary>
        /// <param name="ms"></param>
        public virtual void Sleep(int ms)
        {
            Thread.Sleep(ms);
        }

        public int SafeCommand(params byte[] data)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Null device is an empty device
    /// </summary>
    public class NullDevice : CommBaseObj
    {

       /// <summary>
        /// property for if the device is open
        /// </summary>
        public override bool IsOpen
        {
            get
            {
                return true;
            }
        }

        public override int ReadTimeOut
        {
            get
            {
                return 0;
            }

            set
            {

            }
        }


        /// <summary>
        /// Property for Connection Infomation
        /// </summary>
        public override string ConnectionInfo
        {
            get
            {
                return "No Connection";
            }
        }

        /// <summary>
        /// discard all data in input buffer
        /// </summary>
        public override void Purge()
        {

        }

        /// <summary>
        /// Open device
        /// </summary>
        /// <returns></returns>
        public override void Open()
        {

        }

        /// <summary>
        /// Close device
        /// </summary>
        /// <returns></returns>
        public override void Close()
        {

        }


        /// <summary>
        /// Write a byte 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public override void WriteBytes(params byte[] data)
        {

        }

        /// <summary>
        /// Read a byte, return -1 if failure
        /// </summary>
        /// <returns></returns>
        public override byte ReadByte()
        {
            return 0;
        }

        public override byte[] ReadAll()
        {
            return null;
        }

    }

    public class ComPortWrapper : CommBaseObj
    {
        private int mReadTimeOut = 1000;
        public override int ReadTimeOut
        {
            get
            {
                return mPort.ReadTimeout;
            }
            set
            {
                mPort.ReadTimeout = value;
            }
        }


        SerialPort mPort = new SerialPort();


        public ComPortWrapper()
        {

        }

        /// <summary>
        /// property for if the device is open
        /// </summary>
        public override bool IsOpen
        {
            get
            {
                return mPort.IsOpen;
            }
        }


        /// <summary>
        /// Property for Connection Infomation
        /// </summary>
        public override string ConnectionInfo
        {
            get
            {
                if (IsOpen)
                {
                    return mPort.PortName + " " + mPort.BaudRate.ToString();
                }
                else
                {
                    return mPort.PortName + " Error";
                }
            }
        }

        /// <summary>
        /// discard all data in input buffer
        /// </summary>
        public override void Purge()
        {
            if (!IsOpen)
            {
                return;
            }
            try
            {
                mPort.ReadTimeout = 10;
                while (true)
                {
                    mPort.ReadByte();
                }
            }
            catch
            {

            }
        }

        /// <summary>
        /// Set Parameters, it will initialize the connection
        /// </summary>
        /// <param name="cfg"></param>
        public bool SetParameters(PortData cfg)
        {
            try
            {
                bool portOpen = IsOpen;
                if (portOpen)
                {
                    Close();
                }
                mPort.PortName = cfg.portName;
                mPort.BaudRate = cfg.baudRate;
                mPort.ReadTimeout = cfg.readTimeout;
                mPort.StopBits = cfg.StopBits;
                mPort.Parity = cfg.Parity;
                mReadTimeOut = cfg.readTimeout;
                if (portOpen)
                {
                    Open();
                }

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Open device
        /// </summary>
        /// <returns></returns>
        public override void Open()
        {
            try
            {
                if (!mPort.IsOpen)
                {
                    mPort.Open();
                }
                _OnConnectStatusChange(mPort.PortName + ", " + mPort.BaudRate);
            }
            catch(Exception ex)
            {
                _OnConnectStatusChange(mPort.PortName + " Error");
            }
        }

        /// <summary>
        /// Close device
        /// </summary>
        /// <returns></returns>
        public override void Close()
        {
            try
            {
                mPort.Close();
            }
            catch
            {
            }
        }


        /// <summary>
        /// Write bytes array 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public override void WriteBytes(byte[] data)
        {
            if (IsOpen)
            {
                try
                {
                    mPort.WriteTimeout = 100;
                    mPort.Write(data, 0, data.Length);
                }
                catch
                {

                }

            }
        }

        /// <summary>
        /// Read a byte, return -1 if failure
        /// </summary>
        /// <returns></returns>
        public override byte ReadByte()
        {
            byte nData = 0;
            if (IsOpen)
            {
                mPort.ReadTimeout = mReadTimeOut;
                nData = (byte)mPort.ReadByte();

            }
            else
            {
                throw new Exception("Read Byte Error");
            }
            return nData;
        }

        public override byte[] ReadAll()
        {
            ArrayList ar = new ArrayList();
            try
            {
                while (true)
                {
                    ar.Add(ReadByte());
                }
            }
            catch
            {

            }
            if (ar.Count > 0)
            {
                return (byte[])ar.ToArray(typeof(byte));
            }
            return null;
        }

    }


}
