﻿using _55_CookieCookbook.Recipes.Ingredients;

public class RecipesConsoleUserInteraction : IRecipesUserInteraction
{
    public void ShowMessage(string msg)
    {
        Console.WriteLine(msg);
    }

    public void Exit()
    {
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

    public void PrintExistingRecipes(List<string> allRecipes)
    {
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
