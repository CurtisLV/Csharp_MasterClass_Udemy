using _57_GameDataParser.DataAccess;
using _57_GameDataParser.Model;
using _57_GameDataParser.UserInteraction;

namespace _57_GameDataParser.App;

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
