await new StarWarsPlanetsStatsApp().Run();

// Print all results in console table
// Define the column widths
const int nameWidth = 20;
const int diameterWidth = 10;
const int surfaceWaterWidth = 15;
const int populationWidth = 15;

// Print the header
static string HandleUnknown(object value)
{
    return value?.ToString() == "unknown" ? "" : value?.ToString();
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
        $"{HandleUnknown(planet.name), -nameWidth} | "
            + $"{HandleUnknown(planet.diameter), -diameterWidth} | "
            + $"{HandleUnknown(planet.surface_water), -surfaceWaterWidth} | "
            + $"{HandleUnknown(planet.population), -populationWidth}|"
    );
}

Console.WriteLine("The statistics of which which propery you would like to see?");
Console.WriteLine("population");
Console.WriteLine("diameter");
Console.WriteLine("surface water");
var input = Console.ReadLine().ToLower();

bool shallStop = false;
while (!shallStop)
{
    DataType? selectedType = input switch
    {
        "population" => DataType.Population,
        "diameter" => DataType.Diameter,
        "surface water" => DataType.SurfaceWater,
        _ => null
    };
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();

public enum DataType
{
    Population,
    Diameter,
    SurfaceWater
}
