namespace ForgeMaster
{
    public class JapanSmith
    {
        private readonly ISwordCreateRoot _swordCreateRoot;
        public JapanSmith(ISwordCreateRoot swordStats)
        {
            _swordCreateRoot = swordStats;
        }

        public void ForgeSword()
        {
            _swordCreateRoot.CreateSword("Japan Smith is forging a sword.");
        }

    }
}
