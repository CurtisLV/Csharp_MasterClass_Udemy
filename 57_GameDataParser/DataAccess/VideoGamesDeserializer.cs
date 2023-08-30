using _57_GameDataParser.Logging;
using _57_GameDataParser.Model;
using _57_GameDataParser.UserInteraction;
using System.Text.Json;

namespace _57_GameDataParser.DataAccess;

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
