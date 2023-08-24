using _57_GameDataParser.Model;
using System.Text.Json;
using Serilog;

var log = new LoggerConfiguration().WriteTo.File("log.txt").CreateLogger();
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
        // read the json
        var json = File.ReadAllText(fileName);
        try
        {
            // return VideoGameModel list?
            List<VideoGame> videoGames = JsonSerializer.Deserialize<List<VideoGame>>(json);

            // print all games to console
            PrintVideoGames(videoGames);

            isFilePathValid = true;
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"JSON in the {fileName} was not in a valid format. JSON body:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(json);
            Console.ResetColor();
            Console.WriteLine(
                "Sorry! The application has experienced an unexpected error and will have to be closed."
            );
            // TODO Log here the ex
            log.Information(ex.ToString());
        }
    }
} while (!isFilePathValid);

Console.WriteLine("Press any key to close.");
Console.ReadKey();

static void PrintVideoGames(List<VideoGame> videoGames)
{
    if (videoGames.Count == 0)
    {
        Console.WriteLine("No games are present in the input file.");
    }
    else
    {
        Console.WriteLine("Loaded games are:");
        foreach (VideoGame vg in videoGames)
        {
            Console.WriteLine($"{vg.Title}, released in {vg.ReleaseYear}, rating: {vg.Rating}");
        }
    }
}
