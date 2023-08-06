using _55_CookieCookbook.DataAccess;
using _55_CookieCookbook.Recipes;
using _55_CookieCookbook.Recipes.Ingredients;

public class RecipesRepository : IRecipesRepository
{
    private readonly IStringsRepository _stringsRepository;
    private readonly IIngredientRegister _ingredientRegister;

    public RecipesRepository(
        IStringsRepository stringsRepository,
        IIngredientRegister ingredientRegister
    )
    {
        _stringsRepository = stringsRepository;
        _ingredientRegister = ingredientRegister;
    }

    public List<string> Read(string filePath)
    {
        return _stringsRepository.Read(filePath);
    }

    public void Write(string filePath, List<string> allRecipes)
    {
        //var recipesAsString = new List<string>();
        //foreach (var recipe in allRecipes)
        //{
        //    recipesAsString.Add(string.Join(",", recipe.Ingredients.Select(i => i.Id)));
        //}

        _stringsRepository.Write(filePath, allRecipes);
    }
}
