string name = "masha";
Console.Write("Enter name of user => ");
string enterName = Console.ReadLine();

if(enterName.ToLower() == name)
{
  Console.WriteLine(":):):)");
}
else
{
  Console.Write("Hi, ");
  Console.WriteLine(enterName);
}
