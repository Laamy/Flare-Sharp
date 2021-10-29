using Flare_Sharp.ClientBase.Categories;
using Flare_Sharp.Memory.FlameSDK;

namespace Flare_Sharp.ClientBase.Modules.Modules
{
    public class RapidClick : Module
    {
        public RapidClick() : base("RapidClick", CategoryHandler.registry.categories[0], (char)0x07, false)
        {
        }

        public override void onTick()
        {
            base.onTick();

            Minecraft.keyInformation.Hitting = 0;
        }
    }
}
