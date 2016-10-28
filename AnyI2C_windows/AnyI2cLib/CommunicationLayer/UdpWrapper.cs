

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

using System.IO.Ports;
using System.Net;
using System.Net.Sockets;

using System.Diagnostics;

namespace AnyI2cLib
{
    public class UdpWrapper : CommBaseObj
    {
        string mIp = "255.255.255.255";
        int mSrcPort = 13000;   // the port listened
        int mDestPort = 13001;   // the port send to, this is the port remote site listen
        private int mReadTimeout = 10;
        public override int ReadTimeOut
        {
            get
            {
                return mReadTimeout;
            }
            set
            {
                mReadTimeout = value;
            }
        }

        public delegate void DelegateDataReceived(UdpDataReceivedEventArgs arg);
        public DelegateDataReceived OnDateReceived;

        UdpClient mUdpClient = new UdpClient();


        public UdpWrapper()
        {

        }

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


        /// <summary>
        /// Property for Connection Infomation
        /// </summary>
        public override string ConnectionInfo
        {
            get
            {
                if (IsOpen)
                {
                    return mIp;
                }
                else
                {
                    return mIp + ", Error";
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
                IPEndPoint ep = new IPEndPoint(IPAddress.Broadcast, mSrcPort) ;
                mUdpClient.Receive(ref ep);
            }
            catch
            {

            }
        }


        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                IPEndPoint e = new IPEndPoint(IPAddress.Any, mSrcPort);
                Byte[] receiveBytes = mUdpClient.EndReceive(ar, ref e);
                if (receiveBytes.Length > 0)
                {
                    MyDataReceived(this, new UdpDataReceivedEventArgs(receiveBytes, e));
                }
                mUdpClient.BeginReceive(new AsyncCallback(ReceiveCallback), mUdpClient);

            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
        }

        public class UdpDataReceivedEventArgs : EventArgs
        {
            public byte[] Data;
            public IPEndPoint Ip;
            public UdpDataReceivedEventArgs(byte[] data, IPEndPoint e)
            {
                Data = data;
                Ip = e;
            }
        }

        public void MyDataReceived(object sender, UdpDataReceivedEventArgs e)
        {
            if (OnDateReceived != null)
            {
                OnDateReceived(e);
            }
        }

        /// <summary>
        /// Set Parameters, it will initialize the connection
        /// </summary>
        /// <param name="cfg"></param>
        public bool SetParameters(NetworkConfig cfg)
        {
            try
            {
                bool portOpen = IsOpen;
                if (portOpen)
                {
                    Close();
                }
                mIp = cfg.IPAddress;
                mSrcPort = cfg.UdpPort;
                mDestPort = cfg.NetworkPort;
                if (portOpen)
                {
                    Open();
                }
            }
            catch
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
                IPEndPoint e = new IPEndPoint(IPAddress.Any, mSrcPort);
                mUdpClient = new UdpClient(e);
                mUdpClient.DontFragment = true;
                mUdpClient.BeginReceive(new AsyncCallback(ReceiveCallback), mUdpClient);
                _OnConnectStatusChange(ConnectionInfo);
            }
            catch(Exception ex)
            {
                _OnConnectStatusChange(ConnectionInfo);
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
                mUdpClient.Close();
            }
            catch
            {
            }
        }

        /// <summary>
        /// Write a byte 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public override void WriteBytes(byte[] data)
        {
            if (IsOpen)
            {
                mUdpClient.Send(data, data.Length, mIp, mDestPort);
            }
            else
            {
                //throw new Exception();
            }
        }

        public void WriteBytes(string ip, int destPort, params byte[] data)
        {
            if (IsOpen)
            {
                mUdpClient.Send(data, data.Length, ip, destPort);
            }
            else
            {
                //throw new Exception();
            }
            
        }

        /// <summary>
        /// Read a byte, return -1 if failure
        /// </summary>
        /// <returns></returns>
        public override byte ReadByte()
        {
            throw new NotImplementedException();
        }

        public override byte[] ReadAll()
        {
            IPEndPoint ip = new IPEndPoint(IPAddress.Any, mSrcPort);
            return mUdpClient.Receive(ref ip);
        }

    }
}
