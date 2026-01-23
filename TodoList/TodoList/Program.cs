using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");
Console.WriteLine("[S]ee all TODOs]");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

//reads line from console and stores it in userInput variable
var userInput = Console.ReadLine();

bool isUserInputAbc = userInput == "ABC";
bool isUserInputNotAbc = userInput != "ABC";
bool isUserInputNotAbc2 = !(userInput == "ABC");
Console.WriteLine("User input:" + userInput);
//todo: handle user input

Console.ReadKey(); //preventing window from closing immediately

/*select lines to comment, Ctrl + KC = comments all line using single line comment slashes
 select commented lines, Ctrl + KU = uncomments all lines, whether they be commented using single line comment slashes or multiline comment asterisks and slashes 

 holding Alt + dragging cursor = adding characters to multiple lines */