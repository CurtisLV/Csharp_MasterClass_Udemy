using _57_GameDataParser.Model;

namespace _57_GameDataParser.UserInteraction;

public class GamesPrinter
{
    private readonly IUserInteractor _userInteractor;

    public static void PrintVideoGames(List<VideoGame> videoGames)
    {
        if (videoGames.Count > 0)
        {
            Console.WriteLine("Loaded games are:");
            foreach (VideoGame vg in videoGames)
            {
                (vg.ToString());
            }
        }
        else
        {
            Console.WriteLine("No games are present in the input file.");
        }
    }
}
