using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JablotronProtocol
{
    public class ProtocolPacket
    {
        public const byte Sop = 0x80;
        public const byte Eop = 0x80;

        public byte SOP { get; set; }
        public byte Len { get; set; }
        public byte[] Data { get; set; }
        public UInt16 CRC { get; set; }
        public byte EOP { get; set; }
    }
}
