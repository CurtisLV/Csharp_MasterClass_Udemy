using _57_GameDataParser;
using _57_GameDataParser.Logging;
using _57_GameDataParser.UserInteraction;

var userInteractor = new ConsoleUserInteractor();

var app = new GameDataParserApp(
    userInteractor,
    new GamesPrinter(userInteractor),
    new VideoGamesDeserializer(userInteractor),
    new LocalFileReader()
);
string logFileName = "log.txt";
var logger = Logger.CreateLogger(logFileName);
try
{
    app.Run();
}
catch (Exception ex)
{
    Console.WriteLine(
        "Sorry! The app has experienced an unexpected error and will have to be closed."
    );
    logger.Information(ex.ToString());
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();
