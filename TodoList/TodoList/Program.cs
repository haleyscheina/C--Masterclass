//int[] numbers = new int[5]; //initialized with int default value of 0
//Console.WriteLine("Element at index 0: " + numbers[0]);
//Console.WriteLine("Element at index 1: " + numbers[1]);
//Console.WriteLine("Element at index 2: " + numbers[2]);

//numbers[0] = 5;
//numbers[1] = 6;
//numbers[2] = 7;
//numbers[3] = 17;
//numbers[4] = 22;

//int[] numbers = new int[] { 2, 6, 1, 6, 19 }; //init and skip inferred size
var numbers = new[] { 2, 3, 1, 6, 19 }; //init and skip inferred type
var sum = 0;
for (var i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}
Console.WriteLine($"Sum of elements is: {sum}");
Console.WriteLine("Element at index 0: " + numbers[0]);
Console.WriteLine("Element at index 1: " + numbers[1]);
Console.WriteLine("Element at index 2: " + numbers[2]);
Console.WriteLine("Element at index 3: " + numbers[3]);
Console.WriteLine("Element at index 4: " + numbers[4]);

//var firstFromEnd = numbers[numbers.Length - 1];
//var secondFromEnd = numbers[numbers.Length - 2];
//using the index from end operator:
var firstFromEnd = numbers[^1];
var secondFromEnd = numbers[^2];
Console.WriteLine($"First from end: {firstFromEnd}\nSecond from end: {secondFromEnd}\n");

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