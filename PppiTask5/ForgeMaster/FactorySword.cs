namespace ForgeMaster
{
    public class FactorySword : ISwordCreateRoot
    {
        public void CreateSword(string creator)
        {
            Console.WriteLine(creator);
        }

    }
}
