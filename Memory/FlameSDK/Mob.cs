using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flare_Sharp.Memory.FlameSDK
{
    public class Mob : Actor
    {
        public Mob(ulong addr) : base(addr)
        {
        }

        public Utils.Vec3f location
        {
            get
            {
                Utils.Vec3f vec3 = new Utils.Vec3f();
                vec3.x = currentX3;
                vec3.y = currentY3;
                vec3.z = currentZ3;
                return vec3;
            }
            set
            {
                teleportE(value.x, value.y, value.z);
            }
        }
        public string type
        {
            get
            {
                return MCM.readString(addr + 0x400, 20);
            }
        }
        public float hitboxWidth
        {
            get
            {
                return MCM.readFloat(addr + 0x4C0 + 24);
            }
            set
            {
                MCM.writeFloat(addr + 0x4C0 + 24, value);
            }
        }
        public float hitboxHeight
        {
            get
            {
                return MCM.readFloat(addr + 0x4C0 + 28);
            }
            set
            {
                MCM.writeFloat(addr + 0x4C0 + 28, value);
            }
        }
        public float currentX1
        {
            get
            {
                return MCM.readFloat(addr + 0x4C0);
            }
            set
            {
                MCM.writeFloat(addr + 0x4C0, value);
            }
        }
        public float currentY1
        {
            get
            {
                return MCM.readFloat(addr + 0x4C0 + 4);
            }
            set
            {
                MCM.writeFloat(addr + 0x4C0 + 4, value);
            }
        }
        public float currentZ1
        {
            get
            {
                return MCM.readFloat(addr + 0x4C0 + 8);
            }
            set
            {
                MCM.writeFloat(addr + 0x4C0 + 8, value);
            }
        }
        public float currentX2
        {
            get
            {
                return MCM.readFloat(addr + 0x4C0 + 12);
            }
            set
            {
                MCM.writeFloat(addr + 0x4C0 + 12, value);
            }
        }
        public float currentY2
        {
            get
            {
                return MCM.readFloat(addr + 0x4C0 + 16);
            }
            set
            {
                MCM.writeFloat(addr + 0x4C0 + 16, value);
            }
        }
        public float currentZ2
        {
            get
            {
                return MCM.readFloat(addr + 0x4C0 + 20);
            }
            set
            {
                MCM.writeFloat(addr + 0x4C0 + 20, value);
            }
        }
        public float currentX3
        {
            get
            {
                return MCM.readFloat(addr + 0x2234);
            }
            set
            {
                MCM.writeFloat(addr + 0x2234, value);
            }
        }
        public float currentY3
        {
            get
            {
                return MCM.readFloat(addr + 0x2234 + 4);
            }
            set
            {
                MCM.writeFloat(addr + 0x2234 + 4, value);
            }
        }
        public float currentZ3
        {
            get
            {
                return MCM.readFloat(addr + 0x2234 + 8);
            }
            set
            {
                MCM.writeFloat(addr + 0x2234 + 8, value);
            }
        }

        public string username
        {
            get
            {
                return MCM.readString(addr + 0x8E0, 20);
            }
        }
        public void teleportE(float x, float y, float z)
        {
            currentX3 = x + 0.6f;
            currentY3 = y + 1.8f;
            currentZ3 = z + 0.6f;
        }
        public double distanceTo(Mob e)
        {
            float dX = currentX1 - e.currentX1;
            float dY = currentY1 - e.currentY1;
            float dZ = currentZ1 - e.currentZ1;
            return Math.Sqrt(dX * dX + dY * dY + dZ * dZ);
        }
    }
}