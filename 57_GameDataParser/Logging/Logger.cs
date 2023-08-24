namespace _57_GameDataParser.Logging;
using Serilog;

public static class Logger
{
    public static ILogger CreateLogger(string logFileName)
    {
        return new LoggerConfiguration().WriteTo.File(logFileName).CreateLogger();
    }

    private static object LoggerConfiguration()
    {
        throw new NotImplementedException();
    }
}
