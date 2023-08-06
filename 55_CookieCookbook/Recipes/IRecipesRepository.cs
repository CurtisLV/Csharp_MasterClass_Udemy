using _55_CookieCookbook.Recipes;

public interface IRecipesRepository
{
    List<string> Read(string filePath);
    void Write(string filePath, List<string> allRecipes);
}
