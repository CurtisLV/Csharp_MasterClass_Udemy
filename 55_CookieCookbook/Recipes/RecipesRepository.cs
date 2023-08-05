﻿using _55_CookieCookbook.DataAccess;
using _55_CookieCookbook.Recipes;

public class RecipesRepository : IRecipesRepository
{
    StringsTextualRepository textRepository = new StringsTextualRepository();
    private readonly IStringsRepository _stringsRepository;

    public List<string> Read(string filePath)
    {
        return textRepository.Read(filePath);
    }

    internal void Write(string filePath, List<string> allRecipes)
    {
        textRepository.Write(filePath, allRecipes);
    }
}
