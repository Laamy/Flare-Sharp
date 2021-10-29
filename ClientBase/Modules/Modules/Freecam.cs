using Flare_Sharp.ClientBase.Categories;
using Flare_Sharp.Memory;
using Flare_Sharp.Memory.FlameSDK;
using System;
using System.Collections.Generic;

namespace Flare_Sharp.ClientBase.Modules.Modules
{
    public class Freecam : Module
    {
        List<float> savedCoordinates = new List<float>();
        List<float> savedPitchAndYaw = new List<float>();
        byte savedFlightState;
        public Freecam() : base("Freecam", CategoryHandler.registry.categories[3], (char)0x07, false)
        {
            RegisterToggleSetting("Revert State", true);
        }

        public override void onEnable()
        {
            base.onEnable();
            savedCoordinates.Add(Minecraft.clientInstance.localPlayer.currentX1);
            savedCoordinates.Add((float)Math.Floor(Minecraft.clientInstance.localPlayer.currentY1));
            savedCoordinates.Add(Minecraft.clientInstance.localPlayer.currentZ1);
            savedFlightState = Minecraft.clientInstance.localPlayer.isFlying;
        }

        public override void onDisable()
        {
            base.onDisable();

            if (toggleSettings[0].value)
            {
                Minecraft.clientInstance.localPlayer.teleport(savedCoordinates[0], savedCoordinates[1], savedCoordinates[2]);
                Minecraft.clientInstance.localPlayer.isFlying = savedFlightState;
                savedCoordinates.Clear();
                savedPitchAndYaw.Clear();
            } else
            {
                savedCoordinates.Clear();
                savedPitchAndYaw.Clear();
            }
        }

        public override void onTick()
        {
            base.onTick();
            Minecraft.clientInstance.localPlayer.isFlying = 1;
            Minecraft.clientInstance.localPlayer.Y2 = Minecraft.clientInstance.localPlayer.Y1;
        }
    }
}
