string word;
do
{
    Console.WriteLine("Enter a word longer than 10 letters: ");
    word = Console.ReadLine();
}
while (word.Length <= 10);

//string word = "";
//while(word.Length>=3)
//{
//    Console.WriteLine("Enter a word less than 3 letters: ");
//    word = Console.ReadLine();
//}

//using System.ComponentModel.Design;
//Console.WriteLine("Hello, World!");
//Console.WriteLine("[S]ee all TODOs]");
//Console.WriteLine("[A]dd a TODO");
//Console.WriteLine("[R]emove a TODO");
//Console.WriteLine("[E]xit");

////reads line from console and stores it in userInput variable
//var userInput = Console.ReadLine();

//switch(userInput)
//{
//    case "s":
//    case "S":
//        PrintSelectedOption("See all TODOs");
//        break;
//    case "a":
//    case "A":
//        PrintSelectedOption("Add a TODO");
//        break;
//    case "r":
//    case "R":
//        PrintSelectedOption("Remove a TODO");
//        break;
//    case "e":
//    case "E":
//        PrintSelectedOption("Exit");
//        break;
//    default:
//        Console.WriteLine("Invalid choice.");
//        break;
//}
Console.ReadKey(); //preventing window from closing immediately
//void PrintSelectedOption(string selectedOption)
//{
//    Console.WriteLine("Selected option: " + selectedOption);
//}