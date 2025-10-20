//you choose the smith not a sword

using ForgeMaster;

NorwaySmith norwaySmith = new NorwaySmith(new FactorySword());
JapanSmith japanSmith = new JapanSmith(new FactorySword());
Console.WriteLine("We have, a smiths Norway & Japan:");
Console.Write($"Selected Smith: ");
string selectedSmith = Console.ReadLine();
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
