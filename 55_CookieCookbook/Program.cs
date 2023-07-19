// define if saved in .txt or .json
const FileFormat Format = FileFormat.Json;

// if the defined file is not empty, print all existing recipes

Console.WriteLine("Create a new cookie recipe! Available ingredients are:");

// Printing available ingredients
// Initialize the list of ingredients
List<Ingredient> ingredients = new List<Ingredient>()
{
    new Ingredient()
    {
        Id = 1,
        Name = "Olive Oil",
        Description = "Sauté or dress salads with it."
    },
    new Ingredient()
    {
        Id = 2,
        Name = "Garlic",
        Description = "Sauté for flavor or use in marinades."
    },
    new Ingredient()
    {
        Id = 3,
        Name = "Onions",
        Description = "Sauté for flavor or use as toppings."
    },
    new Ingredient()
    {
        Id = 4,
        Name = "Salt",
        Description = "Sprinkle for taste while cooking."
    },
    new Ingredient()
    {
        Id = 5,
        Name = "Black Pepper",
        Description = "Grind to enhance flavors in dishes."
    },
    new Ingredient()
    {
        Id = 6,
        Name = "Lemon",
        Description = "Squeeze juice or zest for flavor."
    },
    new Ingredient()
    {
        Id = 7,
        Name = "Chicken Broth",
        Description = "Simmer bones for flavorful liquid base."
    },
    new Ingredient()
    {
        Id = 8,
        Name = "Soy Sauce",
        Description = "Use as marinade or dipping sauce."
    }
};

// Access and use the list of ingredients as needed
foreach (Ingredient ingredient in ingredients)
{
    Console.WriteLine($"Ingredient: {ingredient.Name}");
    Console.WriteLine($"Description: {ingredient.Description}");
    Console.WriteLine();
}

public enum FileFormat
{
    Json,
    Txt
}

public class Ingredient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public override string ToString()
    {
        return $"{Name}. {Description}. Add to other ingredients.";
    }
}
