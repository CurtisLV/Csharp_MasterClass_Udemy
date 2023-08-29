﻿using _57_GameDataParser.Logging;
using _57_GameDataParser.Model;
using _57_GameDataParser.UserInteraction;
using System.Text.Json;

namespace _57_GameDataParser;

public class GameDataParserApp
{
    private readonly IUserInteractor _userInteractor;
    private readonly IGamesPrinter _gamesPrinter;
    private readonly IVideoGamesDeserializer _videoGamesDeserializer;
    private readonly IFileReader _fileReader;

    public GameDataParserApp(
        IUserInteractor userInteractor,
        IGamesPrinter gamesPrinter,
        IVideoGamesDeserializer videoGamesDeserializer,
        IFileReader fileReader
    )
    {
        _userInteractor = userInteractor;
        _gamesPrinter = gamesPrinter;
        _videoGamesDeserializer = videoGamesDeserializer;
        _fileReader = fileReader;
    }

    public void Run()
    {
        string fileName = _userInteractor.ReadValidFilePath();
        var fileContents = _fileReader.Read(fileName);
        List<VideoGame> videoGames = _videoGamesDeserializer.Deserialize(fileName, fileContents);
        // print all games to console
        _gamesPrinter.Print(videoGames);
    }
}

public interface IFileReader
{
    string Read(string fileName);
}

public class LocalFileReader : IFileReader
{
    public string Read(string fileName)
    {
        return File.ReadAllText(fileName);
    }
}

public class VideoGamesDeserializer : IVideoGamesDeserializer
{
    private readonly IUserInteractor _userInteractor;

    public VideoGamesDeserializer(IUserInteractor userInteractor)
    {
        _userInteractor = userInteractor;
    }

    public List<VideoGame> Deserialize(string fileName, string fileContents)
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
            _userInteractor.PrintMessage(
                $"JSON in the {fileName} was not in a valid format. JSON body:"
            );
            _userInteractor.PrintError(fileContents);
            _userInteractor.PrintError(
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
    void PrintError(string message);
}

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
