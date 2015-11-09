using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnyI2C
{

    public interface  CommInterface
    {
        byte[] Send(byte [] data, byte readLength);
        byte GetDefaultAddress();

    }
    public interface GuiInterface
    {
        void Show(CommInterface com);
    }

}
