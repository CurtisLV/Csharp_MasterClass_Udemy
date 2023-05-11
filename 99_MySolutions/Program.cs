﻿Console.WriteLine("Hello!");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

// Read line from console and assign to var
string userChoice = Console.ReadLine();
Console.WriteLine("User choice: " + userChoice);

if (userChoice.Length <= 3)
{
    Console.WriteLine("Short answer");
}
else if (userChoice.Length < 10)
{
    Console.WriteLine("Medium answer");
}
else
{
    Console.WriteLine("Long answer");
}

// TODO: handle user input
Console.ReadKey();
