using System.Text.Json;
using _62._1_StarWarsAPI_Assignment.DTOs;

var baseAddress = "https://swapi.dev";
var requestUri = " /api/planets/";

IApiDataReader apiDataReader = new ApiDataReader();
var json = await apiDataReader.Read(baseAddress, requestUri);

var root = JsonSerializer.Deserialize<Root>(json);

// Print all results in console table
// Define the column widths
const int nameWidth = 20;
const int diameterWidth = 10;
const int surfaceWaterWidth = 15;
const int populationWidth = 15;

// Print the header
Console.WriteLine(
    $"{"Planet", -nameWidth} | {"Diameter", -diameterWidth} | {"Surfacewater", -surfaceWaterWidth} | {"Population", -populationWidth}"
);
Console.WriteLine(
    new string('-', nameWidth + diameterWidth + surfaceWaterWidth + populationWidth + 9)
);

// TODO print empty cell when unknown

// Print the data
foreach (var planet in root.results)
{
    string surfaceWater = planet.surface_water == "unknown" ? "" : planet.surface_water;
    string population = planet.population == "unknown" ? "" : planet.population;
    Console.WriteLine(
        $"{planet.name, -nameWidth} | {planet.diameter, -diameterWidth} | {surfaceWater, -surfaceWaterWidth} | {population, -populationWidth}|"
    );
}

Console.ReadKey();
