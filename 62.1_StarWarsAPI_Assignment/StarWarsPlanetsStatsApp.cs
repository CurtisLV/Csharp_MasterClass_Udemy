using System.Text.Json;
using _62._1_StarWarsAPI_Assignment.DTOs;

public class StarWarsPlanetsStatsApp
{
    private readonly IApiDataReader _apiDataReader;
    private readonly IApiDataReader _secondaryApiDataReader;

    public StarWarsPlanetsStatsApp(
        IApiDataReader apiDataReader,
        IApiDataReader secondaryApiDataReader
    )
    {
        _apiDataReader = apiDataReader;
        _secondaryApiDataReader = secondaryApiDataReader;
    }

    public async Task Run()
    {
        string json = null;
        var baseAddress = "https://swapi.dev";
        var requestUri = " /api/planets/";

        try
        {
            IApiDataReader apiDataReader = _apiDataReader;
            json = await apiDataReader.Read(baseAddress, requestUri);
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine(
                "API request was unnsucessful."
                    + "Switching to mock data."
                    + "Exception message: "
                    + ex.Message
            );
        }

        if (json is null)
        {
            //IApiDataReader apiDataReader = new MockStarWarsApiDataReader();
            IApiDataReader apiDataReader = _secondaryApiDataReader;
            json = await apiDataReader.Read(baseAddress, requestUri);
        }

        var root = JsonSerializer.Deserialize<Root>(json);
    }
}
