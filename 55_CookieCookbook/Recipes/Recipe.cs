using _55_CookieCookbook.Recipes.Ingredients;

namespace _55_CookieCookbook.Recipes;

public class Recipe
{
    public IEnumerable<string> Ingredients { get; }

    public Recipe(IEnumerable<string> ingredients)
    {
        Ingredients = ingredients;
    }
}
