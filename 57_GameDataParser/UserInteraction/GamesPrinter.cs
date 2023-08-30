using _57_GameDataParser.App;
using _57_GameDataParser.Model;

namespace _57_GameDataParser.UserInteraction;

public class GamesPrinter : IGamesPrinter
{
    private readonly IUserInteractor _userInteractor;

    public GamesPrinter(IUserInteractor userInteractor)
    {
        _userInteractor = userInteractor;
    }

    public void Print(List<VideoGame> videoGames)
    {
        if (videoGames.Count > 0)
        {
            _userInteractor.PrintMessage(Environment.NewLine + "Loaded games are:");
            foreach (VideoGame vg in videoGames)
            {
                _userInteractor.PrintMessage(vg.ToString());
            }
        }
        else
        {
            _userInteractor.PrintMessage("No games are present in the input file.");
        }
    }
}
