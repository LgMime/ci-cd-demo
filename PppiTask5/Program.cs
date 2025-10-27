//you choose the smith not a sword

using ForgeMaster;

NorwaySmith norwaySmith = new NorwaySmith(new FactorySword());
JapanSmith japanSmith = new JapanSmith(new FactorySword());
Console.WriteLine("We have, a smiths Norway & Japan:"); ///ask user to choose smith
Console.Write($"Selected Smith: "); //on this line user inputs Norway or Japan, because here Write not WriteLine
string selectedSmith = Console.ReadLine(); //input Norway or Japan
if (selectedSmith == "Norway")
{
    norwaySmith.ForgeSword();
}
else if (selectedSmith == "Japan")
{
    japanSmith.ForgeSword();
}
else
{
    Console.WriteLine("No smith selected.");
}
