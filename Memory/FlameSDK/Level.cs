using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flare_Sharp.Memory.FlameSDK
{
    public class Level : SDKObj
    {
        public Level(ulong addr) : base(addr)
        {
        }

        private Mob lookingEntity
        {
            get => new Mob(MCM.readInt64(addr + 0x870));
        }

        private ulong setLookingEnt // patched
        {
            set => MCM.writeInt64(addr + 0x870, value);
        }

        private int lookingState
        {
            get
            {
                return MCM.readInt(addr + 0x850);
            }
            set
            {
                MCM.writeInt(addr + 0x850, value);
            }
        }

        public int lookingBlockSide 
        {
            get
            {
                return MCM.readInt(addr + 0x0);
            }
            set
            {
                MCM.writeInt(addr + 0x0, value);
            }
        }
        public int lookingBlockX
        {
            get
            {
                return MCM.readInt(addr + 0x0);
            }
            set
            {
                MCM.writeInt(addr + 0x0, value);
            }
        }
        public int lookingBlockY
        {
            get
            {
                return MCM.readInt(addr + 0x0);
            }
            set
            {
                MCM.writeInt(addr + 0x0, value);
            }
        }
        public int lookingBlockZ
        {
            get
            {
                return MCM.readInt(addr + 0x0);
            }
            set
            {
                MCM.writeInt(addr + 0x0, value);
            }
        }

        private List<Gamerule> gamerules
        {
            get
            {
                List<Gamerule> returnRules = new List<Gamerule>();
                for (ulong ruleIndex = 0; ruleIndex < 28; ruleIndex++)
                {
                    returnRules.Add(new Gamerule(MCM.readInt64(addr + 0x340) + (ruleIndex * 176)));
                }
                return returnRules;
            }
        }
    }
}
