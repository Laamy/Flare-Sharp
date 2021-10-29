using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flare_Sharp.Memory.FlameSDK
{
    public class ClientInstance : SDKObj
    {
        public ClientInstance(ulong addr) : base(addr)
        {
        }

        public LocalPlayer localPlayer
        { get => new LocalPlayer(MCM.readInt64(addr + 0xB8)); }
    }
}
