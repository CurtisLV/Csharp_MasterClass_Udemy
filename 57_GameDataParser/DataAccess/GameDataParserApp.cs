using _57_GameDataParser.Model;
using _57_GameDataParser.UserInteraction;

namespace _57_GameDataParser.DataAccess;

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
