int userNumber;
do
{
    Console.WriteLine("Enter number larger than 10");
    var userInput = Console.ReadLine();

    if (userInput == "stop")
    {
        break;
    }
    bool isParsableToInt = userInput.All(char.IsDigit);

    if (!isParsableToInt)
    {
        continue;
    }

    userNumber = int.Parse(userInput);
} while (userNumber <= 10);

Console.WriteLine("The loop is finished!");

//Console.WriteLine("Hello!");
//Console.WriteLine("[S]ee all TODOs");
//Console.WriteLine("[A]dd a TODO");
//Console.WriteLine("[R]emove a TODO");
//Console.WriteLine("[E]xit");

//// Read line from console and assign to var
//string userChoice = Console.ReadLine();
//Console.WriteLine("User choice: " + userChoice);

//var result = Add(10, 5);

//bool isLong = IsLong(userChoice);

//Console.WriteLine("Provide a number.");

//string userInput = Console.ReadLine();

//int num = int.Parse(userInput);
//Console.WriteLine(num);

//switch (userInput.ToUpper())
//{
//    case "S":
//        PrintSelectedOption("See all TODOs");
//        break;
//    case "A":
//        PrintSelectedOption("Add a TODO");
//        break;
//    case "R":
//        PrintSelectedOption("Remove a TODO");
//        break;
//    case "E":
//        PrintSelectedOption("Exit");
//        break;
//    default:
//        PrintSelectedOption("Invalid option");
//        break;
//}

//void PrintSelectedOption(string selectedOption)
//{
//    Console.WriteLine($"Selected option: {selectedOption}");
//}

//int Add(int a, int b)
//{
//    return a + b;
//}

//bool IsLong(string input)
//{
//    return input.Length > 10;
//}


Console.ReadKey();
