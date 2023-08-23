using _57_GameDataParser;
using System.Text.Json;

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
        // return VideoGameModel list?
        List<VideoGame> videoGames = JsonSerializer.Deserialize<List<VideoGame>>(json);

        // print all games to console
        foreach (VideoGame vg in videoGames)
        {
            Console.WriteLine($"{vg.Title}, released in {vg.ReleaseYear}, rating: {vg.Rating}");
        }

        isFilePathValid = true;
    }
} while (!isFilePathValid);

Console.WriteLine("Press any key to close.");
Console.ReadKey();
