using System.ComponentModel.Design;
Console.WriteLine("Hello, World!");
Console.WriteLine("[S]ee all TODOs]");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

//reads line from console and stores it in userInput variable
var userInput = Console.ReadLine();

switch(userInput)
{
    case "s":
    case "S":
        PrintSelectedOption("See all TODOs");
        break;
    case "a":
    case "A":
        PrintSelectedOption("Add a TODO");
        break;
    case "r":
    case "R":
        PrintSelectedOption("Remove a TODO");
        break;
    case "e":
    case "E":
        PrintSelectedOption("Exit");
        break;
    default:
        Console.WriteLine("Invalid choice.");
        break;
}

//if (userInput == "S" || userInput == "s")
//{
//    PrintSelectedOption("See all TODOs");
//}
//else if (userInput == "A" || userInput == "a")
//{
//    PrintSelectedOption("Add a TODO");
//}
//else if (userInput == "R" || userInput == "r")
//{
//    PrintSelectedOption("Remove a TODO");
//}
//else if (userInput == "E" || userInput == "e")
//{
//    PrintSelectedOption("Exit");
//}
//else
//{
//    Console.WriteLine("Invalid choice.");
//}
    Console.ReadKey(); //preventing window from closing immediately
void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("Selected option: " + selectedOption);
}