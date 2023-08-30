namespace _57_GameDataParser.UserInteraction;

public class ConsoleUserInteractor : IUserInteractor
{
    public void PrintError(string message)
    {
        var originalConsoleForegroundColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        PrintMessage(message);
        Console.ForegroundColor = originalConsoleForegroundColor;
    }

    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    public string ReadValidFilePath()
    {
        bool isFilePathValid = false;
        string fileName;

        do
        {
            PrintMessage("Enter the name of the file you want to read:");
            fileName = Console.ReadLine();

            // need to check for null and empty input
            if (fileName is null)
            {
                PrintMessage("File cannot be null.");
            }
            else if (fileName == string.Empty)
            {
                PrintMessage("File cannot be empty.");
            }
            else if (!File.Exists(fileName))
            {
                PrintMessage("File not found.");
            }
            else
            {
                // read the json
                isFilePathValid = true;
            }
        } while (!isFilePathValid);
        return fileName;
    }
}
