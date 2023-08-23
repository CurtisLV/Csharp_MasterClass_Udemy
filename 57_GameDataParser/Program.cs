bool isFilePathValid = false;
string fileName;

do
{
    Console.WriteLine("Enter the name of the file you want to read:");
    fileName = Console.ReadLine();

    // need to check for null and empty input
    if (fileName is null)
    {
        Console.WriteLine("File cannot be null.");
    }
    else if (fileName == "")
    {
        Console.WriteLine("File cannot be empty.");
    }
    else if (!File.Exists(fileName))
    {
        // try to parse the whole JSON file
        Console.WriteLine("File not found.");
    }
    else
    {
        // run the code?
    }
} while (!isFilePathValid);

Console.WriteLine("Press any key to close.");
Console.ReadKey();
