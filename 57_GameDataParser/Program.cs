using _57_GameDataParser.Model;
using Serilog;
using System.Text.Json;

bool isFilePathValid = false;
string fileName;

string logFileName = "log.txt";
var logger = new LoggerConfiguration().WriteTo.File(logFileName).CreateLogger();

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
        Console.WriteLine("File not found.");
    }
    else
    {
        // read the json
        var jsonContent = File.ReadAllText(fileName);
        try
        {
            // return VideoGameModel list?
            List<VideoGame> videoGames = JsonSerializer.Deserialize<List<VideoGame>>(jsonContent);

            // print all games to console
            PrintVideoGames(videoGames);

            isFilePathValid = true;
        }
        catch (JsonException ex)
        {
            var originalConsoleForegroundColor = Console.ForegroundColor;
            Console.WriteLine($"JSON in the {fileName} was not in a valid format. JSON body:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(jsonContent);
            Console.ForegroundColor = originalConsoleForegroundColor;
            Console.WriteLine(
                "Sorry! The application has experienced an unexpected error and will have to be closed."
            );
            logger.Information(ex.ToString());
            throw new JsonException($"{ex.Message} The file is: {fileName}", ex);
        }
    }
} while (!isFilePathValid);

Console.WriteLine("Press any key to close.");
Console.ReadKey();

static void PrintVideoGames(List<VideoGame> videoGames)
{
    if (videoGames.Count > 0)
    {
        Console.WriteLine("Loaded games are:");
        foreach (VideoGame vg in videoGames)
        {
            Console.WriteLine(vg.ToString());
        }
    }
    else
    {
        Console.WriteLine("No games are present in the input file.");
    }
}
