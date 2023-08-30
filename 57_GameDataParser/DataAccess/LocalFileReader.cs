using _57_GameDataParser.DataAccess;

namespace _57_GameDataParser.App;

public class LocalFileReader : IFileReader
{
    public string Read(string fileName)
    {
        return File.ReadAllText(fileName);
    }
}
