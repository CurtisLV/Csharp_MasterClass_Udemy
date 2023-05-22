using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

Console.WriteLine("Hello!");

var userInput = "";
List<string> todoList = new List<string>();

do
{
    PrintOptions();
    userInput = Console.ReadLine().ToUpper();

    switch (userInput)
    {
        case "S":
            PrintSelectedOption("See all TODOs");
            PrintAllTodo();
            break;
        case "A":
            bool isAdded;
            do
            {
                Console.WriteLine("Enter the TODO description: ");
                var addTodoInput = Console.ReadLine();
                AddTodo(addTodoInput, out bool isTodoAdded);
                isAdded = isTodoAdded;
            } while (!isAdded);

            break;
        case "R":
            // here we add a do while
            do
            {
                //
            } while (true);
            PrintSelectedOption("Select the index of the TODO you want to remove: ");
            PrintAllTodo();

            break;
        case "E":
            Console.WriteLine("Exit");
            break;
        default:
            Console.WriteLine("Incorrect input");
            break;
    }
} while (userInput != "E");
void PrintAllTodo()
{
    if (todoList.Count > 0)
    {
        for (int i = 1; i <= todoList.Count; i++)
        {
            Console.WriteLine($"{i}. {todoList[i - 1]}");
        }
    }
    else
    {
        Console.WriteLine("No TODOs have been added yet.");
    }
}

void AddTodo(string addTodoInput, out bool isTodoAdded)
{
    if (string.IsNullOrEmpty(addTodoInput))
    {
        Console.WriteLine("The description cannot be empty.");
        isTodoAdded = false;
        return;
    }
    if (todoList.Contains(addTodoInput))
    {
        Console.WriteLine("The description must be unique.");
        isTodoAdded = false;
        return;
    }

    todoList.Add(addTodoInput);
    Console.WriteLine($"TODO successfully added: {addTodoInput}");
    isTodoAdded = true;
}

void PrintOptions()
{
    Console.WriteLine();
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
}

//words.AddRange(new[] { "six", "seven", "eight" });

//foreach (var w in words)
//{
//    if (w == w.ToUpper() && Regex.IsMatch(w, "^[a-zA-Z]+$"))
//    {
//        //
//    }
//}

//words.RemoveAt(0);

//Console.WriteLine(words.IndexOf("five")); // returns an index
//Console.WriteLine(words.IndexOf("random")); // return -1

//Console.WriteLine(words.Contains("five")); // returns true
//Console.WriteLine(words.Contains("random")); // return false

//words.Clear(); // Clears list

//var numbers = new[] { 10, -8, 2, 12, -17 };
//int nonPositiveCount;
//var onlyPositives = GetOnlyPositive(numbers, out nonPositiveCount);

//foreach (var num in onlyPositives)
//{
//    Console.WriteLine(num);
//}
//Console.WriteLine($"Count of non-positive: {nonPositiveCount}");
//Console.ReadKey();
//List<int> GetOnlyPositive(int[] numbers, out int countOfNonPositive)
//{
//    var result = new List<int>();
//    countOfNonPositive = 0;

//    foreach (int num in numbers)
//    {
//        if (num > 0)
//        {
//            result.Add(num);
//        }
//        else
//        {
//            countOfNonPositive++;
//        }
//    }
//    return result;
//}

//Console.WriteLine("Enter a number:");


//int userNumber;
//do
//{
//    Console.WriteLine("Enter number larger than 10");
//    var userInput = Console.ReadLine();

//    if (userInput == "stop")
//    {
//        break;
//    }
//    bool isParsableToInt = userInput.All(char.IsDigit);

//    if (!isParsableToInt)
//    {
//        userNumber = 0;
//        continue;
//    }

//    userNumber = int.Parse(userInput);
//} while (userNumber <= 10);

//Console.WriteLine("The loop is finished!");

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



//int Add(int a, int b)
//{
//    return a + b;
//}

//bool IsLong(string input)
//{
//    return input.Length > 10;
//}
