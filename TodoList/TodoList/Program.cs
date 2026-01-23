using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");
Console.WriteLine("[S]ee all TODOs]");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

//reads line from console and stores it in userInput variable
var userInput = Console.ReadLine();

if (userInput.Length == 0)
{
    Console.WriteLine("Empty choice!");
    int number = 5;
    //Console.WriteLine(number);
    //var word = "ABC"; 
    //if (word.Length > 0)
    //{
    //    //var number = 10; - error: variable with this name already exists in scope
    //    Console.WriteLine(number);
    //    Console.WriteLine(userInput);
    //}
}
else
{
    int number = 10; //works because "number" variable exists only in a different scope
    Console.WriteLine("Non-empty choice: " + userInput);
    // Console.WriteLine(number); - error: out of scope
}
Console.WriteLine("Your choice is: " + userInput);
//Console.WriteLine(number); - error: out of scope
    Console.ReadKey(); //preventing window from closing immediately
