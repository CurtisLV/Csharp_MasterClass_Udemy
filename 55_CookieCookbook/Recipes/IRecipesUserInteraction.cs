using _55_CookieCookbook.Recipes.Ingredients;

public interface IRecipesUserInteraction
{
    void ShowMessage(string msg);
    void Exit();
    void PrintExistingRecipes(IEnumerable<string> allRecipes);
    void PromptToCreateRecipe();
    IEnumerable<Ingredient> ReadIngredientsFromUser();
}
