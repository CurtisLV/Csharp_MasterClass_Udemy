﻿namespace CookieCookbook.Recipes.Ingredients;

public class IngredientsRegister : IIngredientsRegister
{
    public IEnumerable<Ingredient> All { get; } =
        new List<Ingredient>
        {
            new WheatFlour(),
            new SpeltFlour(),
            new Butter(),
            new Chocolate(),
            new Sugar(),
            new Cardamom(),
            new Cinnamon(),
            new CocoaPowder()
        };

    public Ingredient GetById(int id)
    {
        var countOfIngredientsWithGivenId = All.Count(ingredient => ingredient.Id == id);
        if (countOfIngredientsWithGivenId > 1)
        {
            throw new InvalidOperationException(
                $"More than one ingredients have given ID equal {id}."
            );
        }
        return All.FirstOrDefault(ingredient => ingredient.Id == id);
    }
}
