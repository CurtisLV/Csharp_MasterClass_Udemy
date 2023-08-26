using _57_GameDataParser;
using _57_GameDataParser.Model;

var app = new GameDataParserApp();

try
{
    app.Run();
}
catch (Exception ex)
{
    Console.WriteLine(
        "Sorry! The app has experienced an unexpected error and will have to be closed."
    );
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();
