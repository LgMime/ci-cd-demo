//you choose the smith not a sword

using ForgeMaster;
using PppiTask5.ForgeMaster;

NorwaySmith norwaySmith = new NorwaySmith(new FactorySword(), new FactoryArmor());
JapanSmith japanSmith = new JapanSmith(new FactorySword(), new FactoryArmor());
Console.WriteLine("We have, a smiths Norway & Japan:"); ///ask user to choose smith
Console.Write($"Selected Smith: "); //its line where user inputs smith and sees text Selected Smith:
string selectedSmith = Console.ReadLine(); //input Norway or Japan
if (selectedSmith == "Norway")
{
    norwaySmith.ForgeSword();
    norwaySmith.ForgeArmor();
}
else if (selectedSmith == "Japan")
{
    japanSmith.ForgeSword();
    japanSmith.ForgeArmor();
}
else
{
    Console.WriteLine("No smith selected.");
}
