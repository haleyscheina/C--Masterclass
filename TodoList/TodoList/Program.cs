using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");
Console.WriteLine("[S]ee all TODOs]");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

//reads line from console and stores it in userInput variable
var userInput = Console.ReadLine();

if (userInput.Length <= 3)
{
    Console.WriteLine("Short answer");
}
else if (userInput.Length < 10)
{
    Console.WriteLine("Medium answer");
}
else
{
    Console.WriteLine("Long answer");
}
    Console.ReadKey(); //preventing window from closing immediately
