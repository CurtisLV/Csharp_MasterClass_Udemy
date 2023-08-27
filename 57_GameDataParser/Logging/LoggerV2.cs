namespace _57_GameDataParser.Logging;

public class LoggerV2
{
    private readonly string _logFileName;

    public LoggerV2(string logFileName)
    {
        _logFileName = logFileName;
    }

    public void Log(Exception ex)
    {
        var entry =
            $@"[{DateTime.UtcNow}]
            Exception message: {ex.Message}
            Stack trace: {ex.StackTrace}


            ";
    }
}
