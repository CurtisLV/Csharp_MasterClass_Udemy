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
static string FormatValue(object value, int width)
{
    // Check if value is null, "unknown", or empty string
    if (
        value == null
        || value.ToString() == "unknown"
        || string.IsNullOrWhiteSpace(value.ToString())
    )
    {
        return new string(' ', width);
    }

    // Format the value with left alignment and specified width
    return string.Format($"{{0, -{width}}}", value);
}

// Print the header
Console.WriteLine(
    $"{"Planet", -nameWidth} | {"Diameter", -diameterWidth} | {"Surfacewater", -surfaceWaterWidth} | {"Population", -populationWidth}"
);
Console.WriteLine(
    new string('-', nameWidth + diameterWidth + surfaceWaterWidth + populationWidth + 9)
);

// Print the data
foreach (var planet in root.results)
{
    Console.WriteLine(
        $"{FormatValue(planet.name, nameWidth)} | "
            + $"{FormatValue(planet.diameter, diameterWidth)} | "
            + $"{FormatValue(planet.surface_water, surfaceWaterWidth)} | "
            + $"{FormatValue(planet.population, populationWidth)}|"
    );
}

Console.ReadKey();
