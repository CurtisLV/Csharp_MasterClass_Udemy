﻿Console.ReadKey();

public class Pizza
{
    private List<string> _ingredients = new List<string>();

    public void AddIngridients(string ingredient) => _ingredients.Add(ingredient);

    public string Describe() => $"This is a pizza with {string.Join(", ", _ingredients)}";
}

public class Ingredient
{
    //
}

public class Cheddar
{
    public string Name => "Cheddar cheese";
    public int AgedForMonths { get; }
}

public class TomatoSauce
{
    public string Name => "Tomato sauce";
    public int TomatoesIn100Grams { get; }
}

public class Mozzarella
{
    public string Name => "Mozzarella";
    public bool IsLight { get; }
}
