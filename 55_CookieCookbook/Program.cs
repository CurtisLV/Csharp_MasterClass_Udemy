using _55_CookieCookbook.DataAccess;
using _55_CookieCookbook.FileAccess;
using _55_CookieCookbook.Recipes.Ingredients;

// define if saved in .txt or .json
const FileFormat Format = FileFormat.Json;

//const FileFormat Format = FileFormat.Txt;

const string FileName = "recipes";
const string BaseDirectory =
    "C:\\Users\\s3257b\\Desktop\\github.CurtisLV\\Csharp_MasterClass_Udemy\\55_CookieCookbook\\Files";

string fileFormat = Format == FileFormat.Json ? ".json" : ".txt";

string fullFilePath = BaseDirectory + "\\" + FileName + fileFormat;

var cookieRecipeApp = new CookieRecipeApp(new RecipesRepository(), new RecipesConsoleUserInteraction());
cookieRecipeApp.Run(fullFilePath);


public class CookieRecipeApp
{
    private readonly RecipesRepository _recipesRepository;
    private readonly IRecipesUserInteraction _recipesUserInteraction;

    public CookieRecipeApp(RecipesRepository recipesRepository, IRecipesUserInteraction recipesUserInteraction)
    {
        _recipesRepository = recipesRepository;
        _recipesUserInteraction = recipesUserInteraction;
    }
    public void Run(string filePath)
    {
        var allRecipes = _recipesRepository.Read(filePath);
        _recipesUserInteraction.PrintExistingRecipes(allRecipes);

        // print available ingredients could be a part of the below function
        _recipesUserInteraction.PromptToCreateRecipe();

        var ingredients = _recipesUserInteraction.ReadIngredientsFromUser(); 

        if (ingredients.Count > 0)
        {
            var recipe = new Recipe(ingredients);
            // instructor wants to add new recipes to all old ones and only then write to file ??
            allRecipes.Add(recipe);
            _recipesRepository.Write(filePath, allRecipes);

            _recipesUserInteraction.ShowMessage("Recipe added:");
            _recipesUserInteraction.ShowMessage(recipe.ToString());
        }
        else
        {
            _recipesUserInteraction.ShowMessage("No ingredients have been selected. Recipe will not be saved.");
        }

        _recipesUserInteraction.Exit();
    }
}

// Initialize the list of ingredients
IngredientRegister ir = new IngredientRegister();
List<Ingredient> ingredients = new List<Ingredient>(ir.All);

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

// Exit msg was here

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
