public interface IRecipesUserInteraction
{
    void ShowMessage(string msg);
    void Exit();
    void PrintExistingRecipes(IEnumerable<string> allRecipes);
    void PromptToCreateRecipe();
}
