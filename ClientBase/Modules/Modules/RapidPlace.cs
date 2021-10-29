using Flare_Sharp.ClientBase.Categories;
using Flare_Sharp.Memory.FlameSDK;

namespace Flare_Sharp.ClientBase.Modules.Modules
{
    public class RapidPlace : Module
    {
        public RapidPlace() : base("RapidPlace", CategoryHandler.registry.categories[2], (char)0x07, false)
        {
        }

        public override void onTick()
        {
            base.onTick();

            Minecraft.keyInformation.Hitting = 0;
        }
    }
}
