using _57_GameDataParser.Logging;
using _57_GameDataParser.Model;
using _57_GameDataParser.UserInteraction;
using System.Text.Json;

namespace _57_GameDataParser;

public class GameDataParserApp
{
    public void Run()
    {
        string fileName = ReadValidFilePathFromUser();
        var fileContents = File.ReadAllText(fileName);
        List<VideoGame> videoGames = DeserializeVideoGamesFrom(fileName, fileContents);
        // print all games to console
        GamesPrinter.PrintVideoGames(videoGames);
    }

    private static List<VideoGame> DeserializeVideoGamesFrom(string fileName, string fileContents)
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
            Console.WriteLine($"JSON in the {fileName} was not in a valid format. JSON body:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(fileContents);
            Console.ForegroundColor = originalConsoleForegroundColor;
            Console.WriteLine(
                "Sorry! The application has experienced an unexpected error and will have to be closed."
            );
            logger.Information(ex.ToString());
            throw new JsonException($"{ex.Message} The file is: {fileName}", ex);
        }
    }

    private static string ReadValidFilePathFromUser()
    {
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
            else if (fileName == String.Empty)
            {
                Console.WriteLine("File cannot be empty.");
            }
            else if (!File.Exists(fileName))
            {
                Console.WriteLine("File not found.");
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

public interface IUserInteractor
{
    //
}

public class ConsoleUserInteractor : IUserInteractor
{
    //
}
