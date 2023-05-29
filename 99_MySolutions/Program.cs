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
            Console.WriteLine("See all TODOs");
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

            bool isParsingSucc;
            do
            {
                Console.WriteLine("Select the index of the TODO you want to remove: ");
                PrintAllTodo();
                var removeInput = Console.ReadLine();
                isParsingSucc = int.TryParse(removeInput, out int number);

                if (isParsingSucc)
                {
                    // we check if the index exists or is not empty
                    if (number > todoList.Count)
                    {
                        Console.WriteLine("The given index is not valid.");
                        isParsingSucc = false;
                    }
                    else
                    {
                        Console.WriteLine($"TODO removed: {todoList[number - 1]}");
                        todoList.Remove(todoList[number - 1]);
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(removeInput))
                    {
                        Console.WriteLine("Selected index cannot be empty.");
                    }
                    else
                    {
                        Console.WriteLine("The given index is not valid.");
                    }
                }
            } while (!isParsingSucc);

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

Console.ReadKey();
