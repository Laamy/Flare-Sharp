﻿using Flare_Sharp.ClientBase.Categories;
using Flare_Sharp.ClientBase.Keybinds;
using Flare_Sharp.Memory.FlameSDK;
using System;

namespace Flare_Sharp.ClientBase.Modules.Modules
{
    public class InventoryMove : Module
    {
        public InventoryMove() : base("InventoryMove", CategoryHandler.registry.categories[2], (char)0x07, false)
        {
            RegisterSliderSetting("Walk Speed", 00, 03, 05);
            RegisterSliderSetting("Camera Speed", 00, 02, 05);
        }

        public override void onTick()
        {
            base.onTick();
            Utils.Vec3f directionalVec;
            float walkSpeed = sliderSettings[0].value / 10F;
            float camMoveSpeed = sliderSettings[0].value / 10F;

            if (Minecraft.clientInstance.localPlayer.inventoryIsOpen)
            {

                if (KeybindHandler.isKeyDown((char)0x20))
                {
                    if (Minecraft.clientInstance.localPlayer.onGround > 0) Minecraft.clientInstance.localPlayer.velY = 0.4F;
                }

                if (KeybindHandler.isKeyDown('W'))
                {
                    if (!KeybindHandler.isKeyDown('A') && !KeybindHandler.isKeyDown('D'))
                    {
                        directionalVec = Utils.directionalVector((Minecraft.clientInstance.localPlayer.yaw + 90) * (float)Math.PI / 180, (float)Math.PI / 180);
                        Minecraft.clientInstance.localPlayer.velX = walkSpeed * directionalVec.x;
                        Minecraft.clientInstance.localPlayer.velZ = walkSpeed * directionalVec.z;
                    }
                    else if (KeybindHandler.isKeyDown('A'))
                    {
                        directionalVec = Utils.directionalVector((Minecraft.clientInstance.localPlayer.yaw + 70) * (float)Math.PI / 180, (float)Math.PI / 180);
                        Minecraft.clientInstance.localPlayer.velX = walkSpeed * directionalVec.x;
                        Minecraft.clientInstance.localPlayer.velZ = walkSpeed * directionalVec.z;
                    }
                    else if (KeybindHandler.isKeyDown('D'))
                    {
                        directionalVec = Utils.directionalVector((Minecraft.clientInstance.localPlayer.yaw + 110) * (float)Math.PI / 180, (float)Math.PI / 180);
                        Minecraft.clientInstance.localPlayer.velX = walkSpeed * directionalVec.x;
                        Minecraft.clientInstance.localPlayer.velZ = walkSpeed * directionalVec.z;
                    }
                }
                else if (KeybindHandler.isKeyDown('S'))
                {
                    if (!KeybindHandler.isKeyDown('A') && !KeybindHandler.isKeyDown('D'))
                    {
                        directionalVec = Utils.directionalVector((Minecraft.clientInstance.localPlayer.yaw + -90) * (float)Math.PI / 180, (float)Math.PI / 180);
                        Minecraft.clientInstance.localPlayer.velX = walkSpeed * directionalVec.x;
                        Minecraft.clientInstance.localPlayer.velZ = walkSpeed * directionalVec.z;
                    }
                    else if (KeybindHandler.isKeyDown('A'))
                    {
                        directionalVec = Utils.directionalVector((Minecraft.clientInstance.localPlayer.yaw + -70) * (float)Math.PI / 180, (float)Math.PI / 180);
                        Minecraft.clientInstance.localPlayer.velX = walkSpeed * directionalVec.x;
                        Minecraft.clientInstance.localPlayer.velZ = walkSpeed * directionalVec.z;
                    }
                    else if (KeybindHandler.isKeyDown('D'))
                    {
                        directionalVec = Utils.directionalVector((Minecraft.clientInstance.localPlayer.yaw + -110) * (float)Math.PI / 180, (float)Math.PI / 180);
                        Minecraft.clientInstance.localPlayer.velX = walkSpeed * directionalVec.x;
                        Minecraft.clientInstance.localPlayer.velZ = walkSpeed * directionalVec.z;
                    }
                }
                else if (!KeybindHandler.isKeyDown('W') && !KeybindHandler.isKeyDown('S'))
                {
                    if (KeybindHandler.isKeyDown('A'))
                    {
                        directionalVec = Utils.directionalVector((Minecraft.clientInstance.localPlayer.yaw) * (float)Math.PI / 180, (float)Math.PI / 180);
                        Minecraft.clientInstance.localPlayer.velX = walkSpeed * directionalVec.x;
                        Minecraft.clientInstance.localPlayer.velZ = walkSpeed * directionalVec.z;
                    }
                    else if (KeybindHandler.isKeyDown('D'))
                    {
                        directionalVec = Utils.directionalVector((Minecraft.clientInstance.localPlayer.yaw + 180) * (float)Math.PI / 180, (float)Math.PI / 180);
                        Minecraft.clientInstance.localPlayer.velX = walkSpeed * directionalVec.x;
                        Minecraft.clientInstance.localPlayer.velZ = walkSpeed * directionalVec.z;
                    }
                }
            }
        }
    }
}
