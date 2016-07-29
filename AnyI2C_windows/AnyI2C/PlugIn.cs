using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnyI2C
{

    public interface  CommInterface
    {
        // Send data
        byte[] Send(byte [] data, byte readLength);
        
        // Get current address from main gui
        byte GetDefaultAddress();
        
        // Set port on main gui
        void SetPort(byte port);

        // Get current port from main gui
        int GetPort();

        // Log Text on main gui
        void LogText(string text);

        // Get the last Receiving data
        byte []GetLastReceivingData();

        // Get the last Sending data
        byte [] GetLastTransmitData();
    }

    public interface GuiInterface
    {
        // Show Plugin
        void Show(CommInterface com);
    }

}
