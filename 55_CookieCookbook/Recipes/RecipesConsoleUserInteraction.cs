﻿using _55_CookieCookbook.Recipes.Ingredients;

public class RecipesConsoleUserInteraction : IRecipesUserInteraction
{
    List<Ingredient> ingredients;
    private readonly IIngredientRegister _ingredientRegister;

    public RecipesConsoleUserInteraction(IIngredientRegister ingredientRegister)
    {
        // Initialize the list of ingredients
        //IngredientRegister ir = new IngredientRegister();
        //ingredients = new List<Ingredient>(ir.All);
        _ingredientRegister = ingredientRegister;
        ingredients = new List<Ingredient>(_ingredientRegister.All);
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
        PrintAllRecipes(allRecipes.ToList());
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

    public void PromptToCreateRecipe()
    {
        Console.WriteLine("Create a new cookie recipe! Available ingredients are:");

        // Printing available ingredients
        foreach (Ingredient ingredient in ingredients)
        {
            Console.WriteLine($"{ingredient.Id}. {ingredient.Name}");
        }
    }

    public IEnumerable<Ingredient> ReadIngredientsFromUser()
    {
        List<Ingredient> selectedIngredients = new List<Ingredient>();
        while (true)
        {
            Console.WriteLine("Add an ingredient by it's ID or type anything else if finished.");

            var input = Console.ReadLine();
            if (!int.TryParse(input, out int selectedId))
            {
                break;
            }

            Ingredient ingredientData = _ingredientRegister.GetById(selectedId);

            if (ingredientData != null)
            {
                selectedIngredients.Add(ingredientData);
            }
            else
            {
                break;
            }
        }
        return selectedIngredients;
    }
}
