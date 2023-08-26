using _57_GameDataParser;
using _57_GameDataParser.Model;
using _57_GameDataParser.Logging;

var app = new GameDataParserApp();
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
