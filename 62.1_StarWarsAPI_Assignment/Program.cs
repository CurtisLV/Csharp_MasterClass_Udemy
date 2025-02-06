using System.Text.Json;
using _62._1_StarWarsAPI_Assignment.DTOs;

var baseAddress = "https://swapi.dev";
var requestUri = " /api/planets/";

IApiDataReader apiDataReader = new ApiDataReader();
var json = await apiDataReader.Read(baseAddress, requestUri);

var root = JsonSerializer.Deserialize<Root>(json);

foreach (var planet in root.results)
{
    Console.WriteLine($"Planet: {planet.name}, {}");
}

Console.ReadKey();
