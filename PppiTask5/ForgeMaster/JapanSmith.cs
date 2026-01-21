using PppiTask5.ForgeMaster.Model;

namespace ForgeMaster
{
    public class JapanSmith
    {
        private readonly ISwordCreateRoot _swordCreateRoot;
        private readonly IArmorCreateRoot _armorCreateRoot;
        public JapanSmith(ISwordCreateRoot swordStats, IArmorCreateRoot armorCreateRoot)
        {
            _swordCreateRoot = swordStats;
            _armorCreateRoot = armorCreateRoot;
        }

        public void ForgeSword()
        {
            _swordCreateRoot.CreateSword("Japan Smith is forging a sword.");
        }
        public void ForgeArmor()
        {
            _armorCreateRoot.CreateArmor("Japan Smith is forging armor.");
        }

    }
}
