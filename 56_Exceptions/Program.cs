using _56_Exceptions;

//Person invalidPersonObject = new Person("", -100);

Console.WriteLine("Enter a number:");
string input = Console.ReadLine();

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



try
{
    int number = ParseStringToInt(input);
    var result = 10 / number;

    Console.WriteLine($"10 / {number} is {result}");
}
catch (FormatException ex)
{
    Console.WriteLine(
        "Wrong format. Input string is not parsable to int." + "\nException message: " + ex.Message
    );
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(
        "Division by zero is an invalid operation." + "\nException message: " + ex.Message
    );
}
catch (Exception ex)
{
    Console.WriteLine($"Unexpected error: {ex.Message}");
}
finally
{
    Console.WriteLine("Finally block is being executed!");
}

int ParseStringToInt(string input)
{
    return int.Parse(input);
}
try
{
    var result2 = GetFirstElement(new int[0]);
}
catch
{
    throw;
}

//RecursiveMethod(1);

try
{
    var dataFromWeb = SendHttpRequest("www.tvnet.lv");
}
catch (HttpRequestException ex) when (ex.Message == "403")
{
    Console.WriteLine("It was forbidden to access the resource.");
    throw;
}
catch (HttpRequestException ex) when (ex.Message == "404")
{
    Console.WriteLine("The resource was not found.");
    throw;
}
catch (HttpRequestException ex) when (ex.Message == "500")
{
    Console.WriteLine("The server has experienced an internal error.");
    throw;
}

object SendHttpRequest(string url)
{
    return null;
}

List<int> numbers = new List<int> { 1, 2 };
List<int> list = null;

//Console.WriteLine(IsFirstElementPositive(numbers));
//Console.WriteLine(IsFirstElementPositive(list));

try
{
    var result = IsFirstElementPositive(null);
}
catch (ArgumentNullException ex)
{
    //
}

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

bool IsFirstElementPositive(IEnumerable<int> numbers)
{
    try
    {
        var firstElement = GetFirstElement(numbers);
        return firstElement > 0;
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine("The collection is empty!");
        return true;
    }
    catch (NullReferenceException ex)
    {
        Console.WriteLine("Sorry! The application experienced an unexpected error.");
        //throw;
        throw new ArgumentNullException("The collection is null!", ex);
    }
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

// Second coding exercise

static int GetMaxValue(List<int> numbers)
{
    try
    {
        return numbers.Max();
    }
    catch (ArgumentNullException ex)
    {
        throw new ArgumentNullException("The numbers list cannot be null.", ex);
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine("The numbers list cannot be empty.");
        throw;
    }
}
