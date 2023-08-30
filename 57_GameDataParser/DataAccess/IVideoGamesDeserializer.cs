using _57_GameDataParser.Model;

namespace _57_GameDataParser.DataAccess
{
    public interface IVideoGamesDeserializer
    {
        List<VideoGame> Deserialize(string fileName, string fileContents);
    }
}
