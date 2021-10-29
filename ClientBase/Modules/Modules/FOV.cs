using Flare_Sharp.ClientBase.Categories;
using Flare_Sharp.Memory.FlameSDK;

namespace Flare_Sharp.ClientBase.Modules.Modules
{
    public class FOV : Module
    {
        public FOV() : base("FOV", CategoryHandler.registry.categories[2], 'C', false)
        {
            RegisterFloatSliderSetting("Zoom", 0F, 010F, 100F);
        }

        public override void onEnable()
        {
            base.onEnable();
            Minecraft.clientInstance.localPlayer.fieldOfView = sliderFloatSettings[0].value;
        }

        public override void onDisable()
        {
            base.onDisable();
            Minecraft.clientInstance.localPlayer.fieldOfView = 1;
        }
    }
}
