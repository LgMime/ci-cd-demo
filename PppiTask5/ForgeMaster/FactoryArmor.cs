using PppiTask5.ForgeMaster.Model;

namespace PppiTask5.ForgeMaster
{
    public class FactoryArmor: IArmorCreateRoot
    {
        public void CreateArmor(string creator)
        {
            Console.WriteLine(creator);
        }
    }
}
