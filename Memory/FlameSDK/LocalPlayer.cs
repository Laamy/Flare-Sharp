using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flare_Sharp.Memory.FlameSDK
{
    public class LocalPlayer : PlayerEntity
    {
        public LocalPlayer(UInt64 addr) : base(addr)
        {
        }

        //SDK stuffs
        public Level level
        { get => new Level(MCM.readInt64(addr + 0x360)); }
        public PlayerAttributes playerAttributes
        { get => new PlayerAttributes(MCM.evaluatePointer(addr + 0x490, MCM.ceByte2uLong("18 2C0 0"))); }

        //Player offset shiz
        public void teleport(float x, float y, float z)
        {
            currentX1 = x;
            currentY1 = y;
            currentZ1 = z;
            X1 = x;
            X2 = x + 0.6f;
            Y1 = y;
            Y2 = y + 1.8f;
            Z1 = z;
            Z2 = z + 0.6f;
        }

        public double velocityXZ
        { get => Math.Sqrt(velX * velX + velZ * velZ); }

        public double velocityXYZ
        { get => Math.Sqrt(velX * velX + velY * velY + velZ * velZ); }

        public Utils.Vec3f lookingVec
        { get => Utils.directionalVector((Minecraft.clientInstance.localPlayer.yaw + 89.9f) * (float)Math.PI / 178F, Minecraft.clientInstance.localPlayer.pitch * (float)Math.PI / 178F); }

        public byte onGround
        {
            get => MCM.readByte(addr + 0x1D8);
            set => MCM.writeByte(addr + 0x1D8, value);
        }
        public int handSwingPacket
        {
            get => MCM.readInt(addr + 0x7C8);
            set => MCM.writeInt(addr + 0x7C8, value);
        }
        public int onGround_type2
        {
            get => MCM.readInt(addr + 0x1DC);
        }
        public byte isFlying
        {
            get => MCM.readByte(addr + 0x980);
            set => MCM.writeByte(addr + 0x980, value);
        }
        public int isInWater
        {
            get => MCM.readInt(addr + 0x25D);
            set => MCM.writeInt(addr + 0x25D, value);
        }
        public int currentGamemode
        {
            get => MCM.readInt(addr + 0x1D84);
            set => MCM.writeInt(addr + 0x1D84, value);
        }

        public float X1
        {
            get
            {
                return MCM.readFloat(addr+ 0x4C0);
            }
            set
            {
                MCM.writeFloat(addr + 0x4C0, value);
            }
        }
        public float Y1
        {
            get
            {
                return MCM.readFloat(addr+ 0x4C0 + 4);
            }
            set
            {
                MCM.writeFloat(addr + 0x4C0 + 4, value);
            }
        }
        public float Z1
        {
            get
            {
                return MCM.readFloat(addr+ 0x4C0 + 8);
            }
            set
            {
                MCM.writeFloat(addr + 0x4C0 + 8, value);
            }
        }
        public float X2
        {
            get
            {
                return MCM.readFloat(addr+ 0x4C0 + 12);
            }
            set
            {
                MCM.writeFloat(addr + 0x4C0 + 12, value);
            }
        }
        public float Y2
        {
            get
            {
                return MCM.readFloat(addr+ 0x4C0 + 16);
            }
            set
            {
                MCM.writeFloat(addr + 0x4C0 + 16, value);
            }
        }
        public float Z2
        {
            get
            {
                return MCM.readFloat(addr+ 0x4C0 + 20);
            }
            set
            {
                MCM.writeFloat(addr + 0x4C0 + 20, value);
            }
        }
        public int isFalling
        {
            get
            {
                return MCM.readInt(addr + 0x1D8 - 4);
            }
            set
            {
                MCM.writeInt(addr + 0x1D8 - 4, value);
            }
        }
        public float fieldOfView
        {
            get
            {
                return MCM.readFloat(addr + 0x1058);
            }
            set
            {
                MCM.writeFloat(addr + 0x1058, value);
            }
        }
        public float velX
        {
            get
            {
                return MCM.readFloat(addr + 0x4F8);
            }
            set
            {
                MCM.writeFloat(addr + 0x4F8, value);
            }
        }
        public float velY
        {
            get
            {
                return MCM.readFloat(addr+ 0x4F8 + 4);
            }
            set
            {
                MCM.writeFloat(addr + 0x4F8 + 4, value);
            }
        }
        public float velZ
        {
            get
            {
                return MCM.readFloat(addr+ 0x4F8 + 8);
            }
            set
            {
                MCM.writeFloat(addr + 0x4F8 + 8, value);
            }
        }
        public float yaw
        {
            get
            {
                return MCM.readFloat(addr+ 0x138 + 4);
            }
            set
            {
                MCM.writeFloat(addr + 0x138 + 4, value);
            }
        }
        public float pitch
        {
            get
            {
                return MCM.readFloat(addr+ 0x138);
            }
            set
            {
                MCM.writeFloat(addr + 0x138, value);
            }
        }

        public byte heldItemCount
        {
            get
            {
                return MCM.readByte(addr+ 0x2370);
            }
            set
            {
                MCM.writeByte(addr + 0x2370, value);
            }
        }

        public int heldItemID
        {
            get
            {
                return MCM.readInt(addr+ 0x236A);
            }
            set
            {
                MCM.writeInt(addr + 0x236A, value);
            }
        }
        public bool inventoryIsOpen //Located near held item ID (not anymore flare lol)
        {
            get
            {
                return MCM.readInt(addr+ 0x1148) != 0;
            }
        }
    }
}
