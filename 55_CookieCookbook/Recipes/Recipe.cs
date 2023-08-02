using _55_CookieCookbook.Recipes.Ingredients;

namespace _55_CookieCookbook.Recipes;

public class Recipe
{
    public List<Ingredient> Ingredients { get; }

    public Recipe(List<Ingredient> ingredients)
    {
        Ingredients = ingredients;
    }
}
