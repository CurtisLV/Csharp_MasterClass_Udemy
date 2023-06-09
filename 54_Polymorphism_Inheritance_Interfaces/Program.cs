﻿using _54_Polymorphism_Inheritance_Interfaces.Extensions;
using System.Text.Json;

var multilineText =
    @"aaa
bbb
ccc
ddd
";

Console.WriteLine("Count of lines is " + multilineText.CountLines());

Console.ReadKey();

int CountLines(string input) => input.Split(Environment.NewLine).Length;

//int firstSeasonNumber = 0;
//Season spring = (Season)firstSeasonNumber;

//decimal a = 10.01m;

//// implicit conversion
//int integer = 10;
//decimal b = integer;

//// explicit conversion
//decimal c = 10.01m;
//int d = (int)c;

//int secondSeasonNumber = 1;
//Season summer = (Season)secondSeasonNumber;
//Console.WriteLine(summer);

//Console.ReadKey();

// casting with 'as' gives a null instead of runtime error
// so there should be a check 'if not null' when using 'as'

//pizza.AddIngridients(new Cheddar());
//pizza.AddIngridients(new Mozzarella());
//pizza.AddIngridients(new TomatoSauce());
//Console.WriteLine(pizza.ToString());

//var ingridient = new Ingredient();
//ingridient.PublicField = 10;

//Cheddar cheddar = new Cheddar();
//Console.WriteLine(cheddar.Name);
//cheddar.PublicField = 20;


//Ingredient ingredient1 = new Cheddar();
//Console.WriteLine(ingredient1.Name);

//Console.WriteLine("Value in ingridient " + ingridient.PublicField);
//Console.WriteLine("Value in cheddar " + cheddar.PublicField);

//Console.WriteLine(cheddar.PublicMethod());
//Console.WriteLine(cheddar.PrivateMethod());
//Console.WriteLine(cheddar.ProtectedMethod());

//var cheddar = new Cheddar(2, 12);
//Console.WriteLine(cheddar);

//Ingredient ingredient = new Cheddar(2, 12); // upcasting - converting from derived to base class
//Cheddar cheddar = (Cheddar)ingredient; // downcasting - converting from base to derived class;

//Console.WriteLine($"is object? {(ingredient is object)}");
//Console.WriteLine($"is igredient? {(ingredient is Ingredient)}");
//Console.WriteLine($"is cheddar? {(ingredient is Cheddar)}");
//Console.WriteLine($"is mozarella? {(ingredient is Mozzarella)}");

//Console.ReadKey();

//var ingredients = new List<Ingredient> { new Cheddar(), new Mozzarella(), new TomatoSauce() };

//foreach (var ingredient in ingredients)
//{
//    Console.WriteLine(ingredient.Name);
//}


var person = new Person()
{
    FirstName = "John",
    LastName = "Smith",
    YearOfBirth = 1972
};

var asJson = JsonSerializer.Serialize(person);
Console.WriteLine("As JSON: ");
Console.WriteLine(asJson);

//{"FirstName":"John","LastName":"Smith","YearOfBirth":1972}

var personJson = "{\"FirstName\":\"John\",\"LastName\":\"Smith\",\"YearOfBirth\":1972}";

var personFromJson = JsonSerializer.Deserialize<Person>(personJson);

var pizza = new Pizza();

if (pizza is not null)
{
    Console.WriteLine(pizza.ingredient);
}

//Ingredient ingredient = GenerateRandomIngredient();

// casting with 'as' gives a null instead of runtime error
// so there should be a check 'if not null' when using 'as'
//Cheddar cheddar = ingredient as Cheddar;

Console.ReadKey();

var bakeableDishes = new List<IBakeable>() { new Pizza(), new Panettone() };

foreach (var bakeableDish in bakeableDishes)
{
    Console.WriteLine(bakeableDish.GetInstructions());
}

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int YearOfBirth { get; set; }
}

public enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}

public abstract class Dessert
{
    //
}

public interface IBakeable
{
    string GetInstructions();
}

public class Panettone : Dessert, IBakeable
{
    public string GetInstructions() => "Bake at 180 degrees C for 35 minutes";
}

public class Pizza : IBakeable
{
    public Ingredient ingredient;
    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngridients(Ingredient ingredient) => _ingredients.Add(ingredient);

    public string GetInstructions() => "Bake at 250C for 10 minutes";

    public override string ToString() => $"This is a pizza with {string.Join(", ", _ingredients)}";
}

public abstract class Ingredient
{
    public Ingredient(int priceIfExtraTopping)
    {
        Console.WriteLine("Constructor from Ingredient class");
        PriceIfExtraTopping = priceIfExtraTopping;
    }

    public int PriceIfExtraTopping { get; }

    public override string ToString() => Name;

    public virtual string Name { get; } = "Some ingredient!";

    public abstract void Prepare();

    public int PublicField;

    public string PublicMethod() => "This method is PUBLIC in the Ingredient class";

    protected string ProtectedMethod() => "This method is PROTECTED in the Ingredient class";

    private string PrivateMethod() => "This method is PRIVATE in the Ingredient class";
}

public abstract class Cheese : Ingredient
{
    public Cheese(int priceIfExtraTopping)
        : base(priceIfExtraTopping) { }
}

public class Cheddar : Ingredient
{
    public Cheddar(int priceIfExtraTopping, int agedForMonths)
        : base(priceIfExtraTopping)
    {
        AgedForMonths = agedForMonths;
        Console.WriteLine("Constructor from the Cheddar class");
    }

    public override string Name =>
        $"{base.Name}, more specifically, a Cheddar cheese aged for {AgedForMonths} months";
    public int AgedForMonths { get; }

    public override void Prepare() => Console.WriteLine("Grate and sprinkle over pizza.");

    public void UseMethodsFromBaseClass()
    {
        Console.WriteLine(PublicMethod());
        //Console.WriteLine(PrivateMethod());
        Console.WriteLine(ProtectedMethod());
    }
}

public class TomatoSauce : Ingredient
{
    public TomatoSauce(int priceIfExtraTopping)
        : base(priceIfExtraTopping) { }

    public override string Name => "Tomato sauce";
    public int TomatoesIn100Grams { get; }

    public sealed override void Prepare() =>
        Console.WriteLine("Cook tomatoes with basil, garlic and salt. " + "Spread on pizza.");
}

public class SpecialTomatoSauce : TomatoSauce
{
    public SpecialTomatoSauce(int priceIfExtraTopping)
        : base(priceIfExtraTopping)
    {
        //
    }

    // cannot be override sealed (or static) method
    //public override void Prepare()
    //{
    //    base.Prepare();
    //}
}

public sealed class Mozzarella : Cheese
{
    public Mozzarella(int priceIfExtraTopping)
        : base(priceIfExtraTopping) { }

    public override string Name => "Mozzarella";
    public bool IsLight { get; }

    public override void Prepare() =>
        Console.WriteLine("Slice thinly and place on top of the pizza");
}

// Coding assignment

public static class NumericTypesDescriber
{
    public static string Describe(object someObject)
    {
        // If this object is any of the int, double,
        // or decimal types, it should print
        // the type's name and the object value.
        if (someObject is int asInt)
        {
            return $"Int of value {asInt}";
        }

        if (someObject is double || someObject is decimal)
        {
            return $"{someObject.GetType().Name} of value {someObject.ToString()}";
        }

        return null;
    }
}

// Second Coding assignment

public static class ListExtension
{
    public static List<int> TakeEverySecond(this List<int> list)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < list.Count; i += 2)
        {
            result.Add(list[i]);
        }
        return result;
    }
}

// Third coding exercise

public static class NumericTransform
{
    public static int Transform(int number)
    {
        var transformations = new List<INumericTransformation>
        {
            new By1Incrementer(),
            new By2Multiplier(),
            new ToPowerOf2Raiser()
        };

        var result = number;
        foreach (var transformation in transformations)
        {
            result = transformation.Transform(result);
        }
        return result;
    }
}

public class ToPowerOf2Raiser : INumericTransformation
{
    public int Transform(int number) => number * number;
}

public class By2Multiplier : INumericTransformation
{
    public int Transform(int number) => number * 2;
}

public class By1Incrementer : INumericTransformation
{
    public int Transform(int number) => number += 1;
}

public interface INumericTransformation
{
    int Transform(int number);
}
