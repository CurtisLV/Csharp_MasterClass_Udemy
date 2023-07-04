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

//public enum Season
//{
//    Spring,
//    Summer,
//    Autumn,
//    Winter
//}

var pizza = new Pizza();

if (pizza is not null)
{
    Console.WriteLine(pizza.ingredient);
}

Ingredient ingredient = GenerateRandomIngredient();

// casting with 'as' gives a null instead of runtime error
// so there should be a check 'if not null' when using 'as'
Cheddar cheddar = ingredient as Cheddar;

Console.ReadKey();

public class Pizza
{
    public Ingredient ingredient;
    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngridients(Ingredient ingredient) => _ingredients.Add(ingredient);

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
        : base(priceIfExtraTopping)
    {
        //
    }
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
        : base(priceIfExtraTopping)
    {
        //
    }

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

    //public override void Prepare()
    //{
    //    base.Prepare();
    //}
}

public sealed class Mozzarella : Cheese
{
    public Mozzarella(int priceIfExtraTopping)
        : base(priceIfExtraTopping)
    {
        //
    }

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
