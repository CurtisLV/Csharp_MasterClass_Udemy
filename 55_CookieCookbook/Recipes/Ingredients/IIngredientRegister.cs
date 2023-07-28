namespace _55_CookieCookbook.Recipes.Ingredients;

public interface IIngredientRegister
{
    IEnumerable<Ingredient> All { get; }

    Ingredient GetById(int id);
}
