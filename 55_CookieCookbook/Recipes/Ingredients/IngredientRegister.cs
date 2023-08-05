namespace _55_CookieCookbook.Recipes.Ingredients;

public class IngredientRegister : IIngredientRegister
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

    public Ingredient GetById(int id)
    {
        //    foreach (var ingredient in All)
        //    {
        //        if (ingredient.Id == id)
        //        {
        //            return ingredient;
        //        }
        //    }

        //    return null;
        //}
        return All.ToList().Find(ingredient => ingredient.Id == id);
    }
}
