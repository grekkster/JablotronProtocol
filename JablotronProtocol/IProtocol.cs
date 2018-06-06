using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JablotronProtocol
{
    enum State { Ok = 0x01, Error = 0x02, Unknown = 0xFF };
    enum Type { Bool = 0x01, Int8 = 0x10, Int16 = 0x11, String = 0x20 };
    enum Error { Ok = 0x00, UnknownId = 0x10, UnknownType = 0x20, DataLengthError = 0x80, UnknownError = 0xFF };

    interface IProtocol
    {
        State State { get; set; }

        int ID { get; set; }

        Type Type { get; set; }

        Error Error { get; set; }

        int ReadSettings();
        void WriteSettings(int settings);
    }
}
