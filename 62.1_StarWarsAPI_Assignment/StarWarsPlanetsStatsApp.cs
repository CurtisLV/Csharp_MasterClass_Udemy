using System.Text.Json;
using _62._1_StarWarsAPI_Assignment.DTOs;

public class StarWarsPlanetsStatsApp
{
    public async Task Run()
    {
        string json = null;
        var baseAddress = "https://swapi.dev";
        var requestUri = " /api/planets/";

        try
        {
            IApiDataReader apiDataReader = new ApiDataReader();
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
        catch (JsonException ex)
        {
            throw;
        }
        catch (Exception ex)
        {
            throw;
        }

        if (json is null)
        {
            IApiDataReader apiDataReader = new MockStarWarsApiDataReader();
            json = await apiDataReader.Read(baseAddress, requestUri);
        }

        var root = JsonSerializer.Deserialize<Root>(json);
    }
}
