using _55_CookieCookbook.Recipes;

namespace _55_CookieCookbook.App;

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
