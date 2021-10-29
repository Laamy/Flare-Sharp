using Flare_Sharp.ClientBase.Categories;
using Flare_Sharp.Memory;
using Flare_Sharp.Memory.FlameSDK;

namespace Flare_Sharp.ClientBase.Modules.Modules
{
    public class Reach : Module
    {
        public Reach() : base("Reach", CategoryHandler.registry.categories[0], (char)0x07, false)
        {
            RegisterSliderSetting("Distance", 4, 7, 7);
        }

        public override void onEnable()
        {
            base.onEnable();

            MCM.writeBaseFloat(Statics.survivalReachCmp, sliderSettings[0].value);
        }
        public override void onDisable()
        {
            base.onDisable();

            MCM.writeBaseFloat(Statics.survivalReachCmp, 3);
        }
    }
}
