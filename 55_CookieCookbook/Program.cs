using _55_CookieCookbook.DataAccess;
using _55_CookieCookbook.FileAccess;
using _55_CookieCookbook.Recipes.Ingredients;

StringsTextualRepository savingTxt = new StringsTextualRepository();

// define if saved in .txt or .json
const FileFormat extension = FileFormat.Json;

//const FileFormat Format = FileFormat.Txt;


const string FileName = "recipes";
const string BaseDirectory =
    "C:\\Users\\s3257b\\Desktop\\github.CurtisLV\\Csharp_MasterClass_Udemy\\55_CookieCookbook\\Files";

string fileFormat = extension == FileFormat.Json ? ".json" : ".txt";

string fullFilePath = BaseDirectory + "\\" + FileName + fileFormat;

// Initialize the list of ingredients
List<Ingredient> ingredients = new IngredientRegister.All;

// if the defined file is not empty, print all existing recipes
if (File.Exists(fullFilePath))
{
    List<string> allRecipes = savingTxt.Read(fullFilePath);
    PrintAllRecipes(allRecipes);
}

Console.WriteLine("Create a new cookie recipe! Available ingredients are:");

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
    string joinedSelectedIngredients = string.Join(",", selectedIngredients);
    // Happy flow
    Console.WriteLine("Recipe added:");
    // Newly added recipe is printed TODO
    PrintOneRecipe(joinedSelectedIngredients);
    // Store recipe in the txt/json file TODO

    savingTxt.Write(fullFilePath, new List<string> { joinedSelectedIngredients });
}
else
{
    Console.WriteLine("No ingredients have been selected. Recipe will not be saved.");
}

Console.WriteLine("Press any key to exit.");
Console.ReadKey();

void PrintOneRecipe(string joinedSelectedIngredients)
{
    List<string> strings = joinedSelectedIngredients.Split(",").ToList();
    foreach (string str in strings)
    {
        Ingredient ingredient = ingredients.Find(ingredient => ingredient.Id == int.Parse(str));
        Console.WriteLine(ingredient.ToString());
    }
}

void PrintAllRecipes(List<string> recipes)
{
    for (int i = 0; i < recipes.Count; i++)
    {
        Console.WriteLine($"***** {i + 1} *****");
        PrintOneRecipe(recipes[i]);
        Console.WriteLine();
    }
}
