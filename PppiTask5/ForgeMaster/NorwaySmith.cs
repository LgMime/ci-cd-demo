using PppiTask5.ForgeMaster.Model;

namespace ForgeMaster
{
    public class NorwaySmith
    {
        private readonly ISwordCreateRoot _swordCreateRoot;
        private readonly IArmorCreateRoot _armorCreateRoot;
        public NorwaySmith(ISwordCreateRoot swordStats, IArmorCreateRoot armorCreateRoot)
        {
            _swordCreateRoot = swordStats;
            _armorCreateRoot = armorCreateRoot;
        }

        public void ForgeSword()
        {
            _swordCreateRoot.CreateSword("Norway Smith is forging a sword.");
           
        }
        public void ForgeArmor()
        {
            _armorCreateRoot.CreateArmor("Norway Smith is forging armor.");
        }


    }
}
