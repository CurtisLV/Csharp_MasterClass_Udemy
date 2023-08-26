using _57_GameDataParser.Model;

static void PrintVideoGames(List<VideoGame> videoGames)
{
    if (videoGames.Count > 0)
    {
        Console.WriteLine("Loaded games are:");
        foreach (VideoGame vg in videoGames)
        {
            Console.WriteLine(vg.ToString());
        }
    }
    else
    {
        Console.WriteLine("No games are present in the input file.");
    }
}
