namespace _55_CookieCookbook.Recipes.Ingredients;

public class IngredientRegister
{
    public IEnumerable<Ingredient> All { get; } =
        new List<Ingredient>
        {
            new OliveOil(),
            new Garlic(),
            new Onions(),
            new Salt(),
            new BlackPepper(),
            new Lemon(),
            new ChickenBroth(),
            new SoySauce()
        };
}
