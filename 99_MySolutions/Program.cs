Console.WriteLine("Hello!");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

// Read line from console and assign to var
string userChoice = Console.ReadLine();
Console.WriteLine("User choice: " + userChoice);

var result = Add(10, 5);

bool isLong = IsLong(userChoice);
bool IsLong(string? input)
{
    if (input.Length > 10)
    {
        return true;
    }
    return false;
}

//if (userChoice == "S")
//{
//    PrintSelectedOption("See all TODOs");
//}
//else if (userChoice == "A")
//{
//    PrintSelectedOption("Add a TODO");
//}
//else if (userChoice == "R")
//{
//    PrintSelectedOption("Remove a TODO");
//}
//else if (userChoice == "E")
//{
//    PrintSelectedOption("Exit");
//}

//Console.ReadKey();

//void PrintSelectedOption(string selectedOption)
//{
//    Console.WriteLine($"Selected option: {selectedOption}");
//}


int Add(int a, int b)
{
    return a + b;
}
