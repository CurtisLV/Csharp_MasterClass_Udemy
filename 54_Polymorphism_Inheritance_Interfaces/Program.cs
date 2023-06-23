﻿//var pizza = new Pizza();
//pizza.AddIngridients(new Cheddar());
//pizza.AddIngridients(new Mozzarella());
//pizza.AddIngridients(new TomatoSauce());

//var ingridient = new Ingredient();
//ingridient.PublicField = 10;

//Cheddar cheddar = new Cheddar();
//Console.WriteLine(cheddar.Name);

//Ingredient ingredient1 = new Cheddar();
//Console.WriteLine(ingredient1.Name);

//cheddar.PublicField = 20;

//Console.WriteLine("Value in ingridient " + ingridient.PublicField);
//Console.WriteLine("Value in cheddar " + cheddar.PublicField);

//Console.WriteLine(cheddar.PublicMethod());
//Console.WriteLine(cheddar.PrivateMethod());
//Console.WriteLine(cheddar.ProtectedMethod());

var ingredients = new List<Ingredient> { new Cheddar(), new Mozzarella(), new TomatoSauce() };

foreach (var ingredient in ingredients)
{
    Console.WriteLine(ingredient.Name);
}

public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngridients(Ingredient ingredient) => _ingredients.Add(ingredient);

    public string Describe() => $"This is a pizza with {string.Join(", ", _ingredients)}";
}

public class Ingredient
{
    public virtual string Name { get; } = "Some ingredient!";

    public int PublicField;

    public string PublicMethod()
    {
        return "This method is PUBLIC in the Ingredient class";
    }

    protected string ProtectedMethod()
    {
        return "This method is PROTECTED in the Ingredient class";
    }

    private string PrivateMethod()
    {
        return "This method is PRIVATE in the Ingredient class";
    }
}

public class Cheddar : Ingredient
{
    public override string Name => "Cheddar cheese";
    public int AgedForMonths { get; }

    public void UseMethodsFromBaseClass()
    {
        Console.WriteLine(PublicMethod());
        //Console.WriteLine(PrivateMethod());
        Console.WriteLine(ProtectedMethod());
    }
}

public class TomatoSauce : Ingredient
{
    public override string Name => "Tomato sauce";
    public int TomatoesIn100Grams { get; }
}

public class Mozzarella : Ingredient
{
    public override string Name => "Mozzarella";
    public bool IsLight { get; }
}
