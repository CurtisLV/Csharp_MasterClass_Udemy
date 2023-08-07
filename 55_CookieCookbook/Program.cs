using _55_CookieCookbook.DataAccess;
using _55_CookieCookbook.FileAccess;
using _55_CookieCookbook.Recipes;
using _55_CookieCookbook.Recipes.Ingredients;

// define if saved in .txt or .json
const FileFormat Format = FileFormat.Json;

//const FileFormat Format = FileFormat.Txt;

const string FileName = "recipes";
const string BaseDirectory =
    "C:\\Users\\s3257b\\Desktop\\github.CurtisLV\\Csharp_MasterClass_Udemy\\55_CookieCookbook\\Files";

//string filePath = Format == FileFormat.Json ? $"{FileName}.json" : $"{FileName}.txt";

var fileMetadata = new FileMetadata(FileName, Format);

string fullFilePath = BaseDirectory + "\\" + fileMetadata.ToPath();

IStringsRepository stringsRepository =
    Format == FileFormat.Json ? new StringsJsonRepository() : new StringsTextualRepository();

var ingredientsRegister = new IngredientRegister();

var cookieRecipeApp = new CookieRecipeApp(
    new RecipesRepository(stringsRepository, ingredientsRegister),
    new RecipesConsoleUserInteraction(ingredientsRegister)
);
cookieRecipeApp.Run(fullFilePath);

public class CookieRecipeApp
{
    private readonly IRecipesRepository _recipesRepository;
    private readonly IRecipesUserInteraction _recipesUserInteraction;

    public CookieRecipeApp(
        IRecipesRepository recipesRepository,
        IRecipesUserInteraction recipesUserInteraction
    )
    {
        _recipesRepository = recipesRepository;
        _recipesUserInteraction = recipesUserInteraction;
    }

    public void Run(string filePath)
    {
        var allRecipes = new List<string>();
        if (File.Exists(filePath))
        {
            allRecipes = _recipesRepository.Read(filePath);
            _recipesUserInteraction.PrintExistingRecipes(allRecipes);
        }

        // print available ingredients could be a part of the below function
        _recipesUserInteraction.PromptToCreateRecipe();

        var ingredients = _recipesUserInteraction.ReadIngredientsFromUser();
        //ingredients = ingredients.ToList();

        if (ingredients.Count() > 0)
        {
            string joinedSelectedIngredients = string.Join(",", ingredients.Select(i => i.Id));
            var recipe = new Recipe(ingredients);
            // instructor wants to add new recipes to all old ones and only then write to file ??
            //allRecipes.Add(recipe.ToString()); // TODO this is wrong
            //allRecipes.Add(joinedSelectedIngredients);
            //_recipesRepository.Write(filePath, allRecipes);
            _recipesRepository.Write(filePath, new List<string> { joinedSelectedIngredients });
            //_recipesRepository.Write(filePath, allRecipes);

            _recipesUserInteraction.ShowMessage("Recipe added:");
            _recipesUserInteraction.ShowMessage(recipe.ToString());
        }
        else
        {
            _recipesUserInteraction.ShowMessage(
                "No ingredients have been selected. Recipe will not be saved."
            );
        }

        _recipesUserInteraction.Exit();
    }
}
