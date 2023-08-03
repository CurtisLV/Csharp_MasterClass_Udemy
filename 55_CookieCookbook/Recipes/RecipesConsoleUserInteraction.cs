using _55_CookieCookbook.Recipes.Ingredients;

public class RecipesConsoleUserInteraction : IRecipesUserInteraction
{
    List<Ingredient> ingredients;

    public RecipesConsoleUserInteraction()
    {
        // Initialize the list of ingredients
        IngredientRegister ir = new IngredientRegister();
        ingredients = new List<Ingredient>(ir.All);
    }

    public void ShowMessage(string msg)
    {
        Console.WriteLine(msg);
    }

    public void Exit()
    {
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

    public void PrintExistingRecipes(IEnumerable<string> allRecipes)
    {
        Console.WriteLine("Existing recipes are:" + Environment.NewLine);
        PrintAllRecipes(allRecipes);
    }

    void PrintOneRecipe(string joinedSelectedIngredients)
    {
        List<string> strings = joinedSelectedIngredients.Split(",").ToList();
        foreach (string str in strings)
        {
            Ingredient ingredient = ingredients.Find(ingredient => ingredient.Id == int.Parse(str));
            Console.WriteLine(ingredient.ToString());
        }
    }

    void PrintAllRecipes(List<string> recipes)
    {
        for (int i = 0; i < recipes.Count; i++)
        {
            Console.WriteLine($"***** {i + 1} *****");
            PrintOneRecipe(recipes[i]);
            Console.WriteLine();
        }
    }
}
