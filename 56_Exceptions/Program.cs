using _56_Exceptions;

//Person invalidPersonObject = new Person("", -100);

//Console.WriteLine("Enter a number:");
//string input = Console.ReadLine();

//var emptyCollection = new List<int>();

//var firstElement = GetFirstElement(emptyCollection);
//var firstUsingLinq = emptyCollection.First();

//var numbers = new int[] { 1, 2, 3 };
//int fourth = numbers[3];

//bool has7 = CheckIfContains7(7, numbers);

//bool CheckIfContains7(int value, int[] numbers)
//{
//    throw new NotImplementedException();
//}



//try
//{
//    int number = ParseStringToInt(input);
//    var result = 10 / number;

//    Console.WriteLine($"10 / {number} is {result}");
//}
//catch (FormatException ex)
//{
//    Console.WriteLine(
//        "Wrong format. Input string is not parsable to int." + "\nException message: " + ex.Message
//    );
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine(
//        "Division by zero is an invalid operation." + "\nException message: " + ex.Message
//    );
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Unexpected error: {ex.Message}");
//}
//finally
//{
//    Console.WriteLine("Finally block is being executed!");
//}

//int ParseStringToInt(string input)
//{
//    return int.Parse(input);
//}
//try
//{
//    var result2 = GetFirstElement(new int[0]);
//}
//catch
//{
//    throw;
//}

//RecursiveMethod(1);

Console.ReadKey();

//void RecursiveMethod(int counter)
//{
//    Console.WriteLine($"I am going to call myself! Counter is {counter}");
//    if (counter < 10)
//    {
//        RecursiveMethod(counter + 1);
//    }
//}

int GetFirstElement(IEnumerable<int> numbers)
{
    foreach (var num in numbers)
    {
        return num;
    }

    throw new InvalidOperationException("The collection cannot be empty!");
}

bool IsFirstElementPositive()
{
    //
}


// First coding exercise
//int result = DivideNumbers(4, 0);
//Console.WriteLine(result);

//static int DivideNumbers(int a, int b)
//{
//    try
//    {
//        return a / b;
//    }
//    catch
//    {
//        Console.WriteLine("Division by zero.");
//        return 0;
//    }
//    finally
//    {
//        Console.WriteLine("The DivideNumbers method ends.");
//    }
//}
