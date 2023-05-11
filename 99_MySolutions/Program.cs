Console.WriteLine("Hello!");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

// Read line from console and assign to var
string userChoice = Console.ReadLine();
Console.WriteLine("User choice: " + userChoice);

if (userChoice == "S")
{
    PrintSelectedOption("See all TODOs");
}
else if (userChoice == "A")
{
    PrintSelectedOption("Add a TODO");
}
else if (userChoice == "R")
{
    PrintSelectedOption("Remove a TODO");
}
else if (userChoice == "E")
{
    PrintSelectedOption("Exit");
}

// TODO: handle user input
Console.ReadKey();

void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("Selected option: " + selectedOption);
}
