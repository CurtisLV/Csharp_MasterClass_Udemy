public interface IRecipesUserInteraction
{
    void ShowMessage(string msg);
    void Exit();
    void PrintExistingRecipes(List<string> allRecipes);
}
