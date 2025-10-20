namespace ForgeMaster
{
    public class NorwaySmith
    {
        private readonly ISwordCreateRoot _swordCreateRoot;
        public NorwaySmith(ISwordCreateRoot swordStats)
        {
            _swordCreateRoot = swordStats;
        }

        public void ForgeSword()
        {
            _swordCreateRoot.CreateSword("Norway Smith is forging a sword.");
        }


    }
}
