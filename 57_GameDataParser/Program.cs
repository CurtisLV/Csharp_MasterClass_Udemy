using System.Text.RegularExpressions;

var input = "";

while (input == null || input == "")
{
    Console.WriteLine("Enter the name of the file you want to read:");
    input = Console.ReadLine();
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();

static bool IsJsonFile(string filename)
{
    // Using regex to match the "*.json" file format
    string pattern = @"\.json$";
    return Regex.IsMatch(filename, pattern, RegexOptions.IgnoreCase);
}
