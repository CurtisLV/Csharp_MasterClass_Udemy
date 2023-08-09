Console.WriteLine("Enter a number:");
string input = Console.ReadLine();

try
{
    int number = ParseStringToInt(input);
    Console.WriteLine("String successfully parsed, result is " + number);
}
catch (Exception)
{
    Console.WriteLine("An exception was thrown.");
}
finally
{
    Console.WriteLine("Finally block is being executed!");
}
Console.ReadKey();

int ParseStringToInt(string input)
{
    try
    {
        return int.Parse(input);
    }
    catch (Exception)
    {
        Console.WriteLine($"Parsing error in the {nameof(ParseStringToInt)} method.");
        return 0;
    }
}
