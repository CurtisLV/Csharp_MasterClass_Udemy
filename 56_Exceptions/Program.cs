Console.WriteLine("Enter a number:");
string input = Console.ReadLine();

try
{
    int number = ParseStringToInt(input);
}
catch (Exception)
{
    Console.WriteLine("An exception was thrown.");
}

Console.ReadKey();

int ParseStringToInt(string input)
{
    return int.Parse(input);
}
