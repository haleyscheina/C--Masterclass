var number = 0;
var word = "abc";
word += "d";
while (number <10)
{
    //number = number + 1;
    //number *= 2; //infinite loop, multiplying by 0*2
    number++;
    Console.WriteLine("Number is: " + number);
}
Console.WriteLine("The loop is finished.");

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