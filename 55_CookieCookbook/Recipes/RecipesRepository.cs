using _55_CookieCookbook.DataAccess;
using _55_CookieCookbook.Recipes;

public class RecipesRepository : IRecipesRepository
{
    private readonly IStringsRepository _stringsRepository;

    public RecipesRepository(IStringsRepository stringsRepository)
    {
        _stringsRepository = stringsRepository;
    }

    public List<string> Read(string filePath)
    {
        return _stringsRepository.Read(filePath);
    }

    internal void Write(string filePath, List<string> allRecipes)
    {
        _stringsRepository.Write(filePath, allRecipes);
    }
}
