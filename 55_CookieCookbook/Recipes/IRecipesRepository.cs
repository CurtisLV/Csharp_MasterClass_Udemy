using _55_CookieCookbook.Recipes;

public interface IRecipesRepository
{
    List<Recipe> Read(string filePath);
}
