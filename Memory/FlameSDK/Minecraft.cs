using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flare_Sharp.Memory.FlameSDK
{
    public class Minecraft
    {
        public static KeyInformation keyInformation
        {
            get
            {
                return new KeyInformation(MCM.baseEvaluatePointer(0x04171058, MCM.ceByte2uLong("490 2A0 8 0")));
            }
        }
        public static ClientInstance clientInstance
        {
            get
            {
                return new ClientInstance(MCM.baseEvaluatePointer(0x04209468, MCM.ceByte2uLong("0 18 0")));
            }
        }
    }
}
