Console.WriteLine("Enter a number:");
string input = Console.ReadLine();

try
{
    int number = ParseStringToInt(input);
    Console.WriteLine("String successfully parsed, result is " + number);
}
catch (Exception ex)
{
    Console.WriteLine("An exception was thrown. Exception message: " + ex.Message);
}
finally
{
    Console.WriteLine("Finally block is being executed!");
}

int ParseStringToInt(string input)
{
    return int.Parse(input);
}

Console.ReadKey();

// First coding exercise
int result = DivideNumbers(4, 0);
Console.WriteLine(result);

static int DivideNumbers(int a, int b)
{
    try
    {
        return a / b;
    }
    catch
    {
        Console.WriteLine("Division by zero.");
        return 0;
    }
    finally
    {
        Console.WriteLine("The DivideNumbers method ends.");
    }
}
