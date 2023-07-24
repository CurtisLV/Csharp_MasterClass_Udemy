using _55_CookieCookbook.DataAccess;

StringsTextualRepository savingTxt = new StringsTextualRepository();

const string FileName = "recipes.txt";
const string BaseDirectory =
    "C:\\Users\\s3257b\\Desktop\\github.CurtisLV\\Csharp_MasterClass_Udemy\\55_CookieCookbook\\Files";

// define if saved in .txt or .json
const FileFormat Format = FileFormat.Json;

// if the defined file is not empty, print all existing recipes TODO

Console.WriteLine("Create a new cookie recipe! Available ingredients are:");

// one class for saving in .json, other for saving in .txt but both have the same interface TODO

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

List<string> selectedIngredients = new List<string>();

// Printing available ingredients
foreach (Ingredient ingredient in ingredients)
{
    Console.WriteLine($"{ingredient.Id}. {ingredient.Name}");
}

while (true)
{
    Console.WriteLine("Add an ingredient by it's ID or type anything else if finished.");

    var input = Console.ReadLine();
    if (!int.TryParse(input, out int selectedId))
    {
        break;
    }

    Ingredient ingredientData = ingredients.Find(ingredient => ingredient.Id == selectedId);

    if (ingredientData != null)
    {
        selectedIngredients.Add(ingredientData.Id.ToString());
    }
    else
    {
        break;
    }
}

if (selectedIngredients.Count > 0)
{
    string joinedSelectedIngredients = string.Join(" ", selectedIngredients);
    // Happy flow
    Console.WriteLine("Recipe added:");
    // Newly added recipe is printed TODO
    PrintingARecipe(joinedSelectedIngredients);
    // Store recipe in the txt/json file TODO

    savingTxt.Write(
        BaseDirectory + "\\" + FileName,
        new List<string> { joinedSelectedIngredients }
    );
}
else
{
    // Unhappy flow
}

void PrintingARecipe(string joinedSelectedIngredients)
{
    foreach (var i in joinedSelectedIngredients)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("Press any key to exit.");

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
        return $"{Name}. {Description} Add to other ingredients.";
    }
}
