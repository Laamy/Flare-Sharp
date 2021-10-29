using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flare_Sharp.Memory.FlameSDK
{
    public class KeyInformation : Actor
    {
        public KeyInformation(UInt64 addr) : base(addr)
        {
        }

        public byte inMenu
        {
            get => MCM.readByte(addr + 0x4B);
            set => MCM.writeByte(addr + 0x4B, value);
        }

        public byte Hitting
        {
            get => MCM.readByte(addr + 0x50);
            set => MCM.writeByte(addr + 0x50, value);
        }

        public byte Placing
        {
            get => MCM.readByte(addr + 0x51);
            set => MCM.writeByte(addr + 0x51, value);
        }

        public byte Picking
        {
            get => MCM.readByte(addr + 0x52);
            set => MCM.writeByte(addr + 0x52, value);
        }
    }
}
