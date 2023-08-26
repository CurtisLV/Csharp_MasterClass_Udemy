using _57_GameDataParser.Model;
using _57_GameDataParser.UserInteraction;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _57_GameDataParser;

public class GameDataParserApp
{
    public void Run()
    {
        bool isFilePathValid = false;
        string fileName;

        string logFileName = "log.txt";
        var logger = new LoggerConfiguration().WriteTo.File(logFileName).CreateLogger();
        var _userInteraction = new GamesPrinter();

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
                    List<VideoGame> videoGames = JsonSerializer.Deserialize<List<VideoGame>>(
                        jsonContent
                    );

                    // print all games to console
                    _userInteraction.PrintVideoGames(videoGames);

                    isFilePathValid = true;
                }
                catch (JsonException ex)
                {
                    var originalConsoleForegroundColor = Console.ForegroundColor;
                    Console.WriteLine(
                        $"JSON in the {fileName} was not in a valid format. JSON body:"
                    );
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
    }
}
