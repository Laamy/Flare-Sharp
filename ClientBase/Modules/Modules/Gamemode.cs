﻿using Flare_Sharp.ClientBase.Categories;
using Flare_Sharp.Memory.FlameSDK;

namespace Flare_Sharp.ClientBase.Modules.Modules
{
    public class Gamemode : Module
    {
        public int savedGamemode;
        public Gamemode() : base("Gamemode", CategoryHandler.registry.categories[2], (char)0x07, false)
        {
            RegisterSliderSetting("Mode", 0, 1, 2);
        }

        public override void onEnable()
        {
            base.onEnable();

            savedGamemode = Minecraft.clientInstance.localPlayer.currentGamemode;
            Minecraft.clientInstance.localPlayer.currentGamemode = sliderSettings[0].value;
        }

        public override void onDisable()
        {
            base.onDisable();

            Minecraft.clientInstance.localPlayer.currentGamemode = savedGamemode;
        }
    }
}
