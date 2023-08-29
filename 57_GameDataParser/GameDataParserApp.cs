using _57_GameDataParser.Logging;
using _57_GameDataParser.Model;
using _57_GameDataParser.UserInteraction;
using System.Text.Json;

namespace _57_GameDataParser;

public class GameDataParserApp
{
    private readonly IUserInteractor _userInteractor;

    public GameDataParserApp(IUserInteractor userInteractor)
    {
        _userInteractor = userInteractor;
    }

    public void Run()
    {
        string fileName = _userInteractor.ReadValidFilePath();
        var fileContents = File.ReadAllText(fileName);
        List<VideoGame> videoGames = DeserializeVideoGamesFrom(fileName, fileContents);
        // print all games to console
        GamesPrinter.PrintVideoGames(videoGames);
    }

    private List<VideoGame> DeserializeVideoGamesFrom(string fileName, string fileContents)
    {
        string logFileName = "log.txt";
        var logger = Logger.CreateLogger(logFileName);
        try
        {
            // return VideoGameModel list?
            return JsonSerializer.Deserialize<List<VideoGame>>(fileContents);
        }
        catch (JsonException ex)
        {
            var originalConsoleForegroundColor = Console.ForegroundColor;
            _userInteractor.PrintMessage(
                $"JSON in the {fileName} was not in a valid format. JSON body:"
            );
            Console.ForegroundColor = ConsoleColor.Red;
            _userInteractor.PrintMessage(fileContents);
            Console.ForegroundColor = originalConsoleForegroundColor;
            _userInteractor.PrintMessage(
                "Sorry! The application has experienced an unexpected error and will have to be closed."
            );
            logger.Information(ex.ToString());
            throw new JsonException($"{ex.Message} The file is: {fileName}", ex);
        }
    }
}

public interface IUserInteractor
{
    string ReadValidFilePath();

    void PrintMessage(string message);
}

public class ConsoleUserInteractor : IUserInteractor
{
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
            else if (fileName == String.Empty)
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
