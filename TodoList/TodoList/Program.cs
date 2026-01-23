using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");
Console.WriteLine("[S]ee all TODOs]");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

//reads line from console and stores it in userInput variable
var userInput = Console.ReadLine();
bool isLong = IsLong(userInput);

var result = Add(5, 10);
Console.WriteLine("10 + 5 = " + result);
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
Console.ReadKey(); //preventing window from closing immediately
//void PrintSelectedOption(string selectedOption)
//{
//    Console.WriteLine("Selected option: " + selectedOption);
//}

int Add(int a, int b)
{
    //if (a > 10)
    //{
    //    return a + b; // error - not all code paths return a value
    //}
    return a + b;
}

bool IsLong(string input)
{
    //if(input.Length > 10)
    //{
    //    return true;
    //}
    ////else
    ////{
    ////    return false;
    ////}
    //return false;

    return input.Length > 10;
    //code refactoring - the process of improving the code quality without altering its behavior
}