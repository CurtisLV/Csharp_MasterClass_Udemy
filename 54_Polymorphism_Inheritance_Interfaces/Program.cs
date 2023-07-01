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

Console.ReadKey();

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

public class Pizza
{
    public Ingredient ingredient;
    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngridients(Ingredient ingredient) => _ingredients.Add(ingredient);

    public override string ToString() => $"This is a pizza with {string.Join(", ", _ingredients)}";
}

public class Ingredient
{
    public Ingredient(int priceIfExtraTopping)
    {
        Console.WriteLine("Constructor from Ingredient class");
        PriceIfExtraTopping = priceIfExtraTopping;
    }

    public int PriceIfExtraTopping { get; }

    public override string ToString() => Name;

    public virtual string Name { get; } = "Some ingredient!";

    public int PublicField;

    public string PublicMethod() => "This method is PUBLIC in the Ingredient class";

    protected string ProtectedMethod() => "This method is PROTECTED in the Ingredient class";

    private string PrivateMethod() => "This method is PRIVATE in the Ingredient class";
}

public class Cheese : Ingredient
{
    //
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
}

public class Mozzarella : Cheese
{
    public Mozzarella(int priceIfExtraTopping)
        : base(priceIfExtraTopping)
    {
        //
    }

    public override string Name => "Mozzarella";
    public bool IsLight { get; }
}

// Coding assignment

public static class NumericTypesDescriber
{
    public static string Describe(object someObject)
    {
        // If this object is any of the int, double,
        // or decimal types, it should print
        // the type's name and the object value.
        if (someObject is int || someObject is double || someObject is decimal)
        {
            return $"{someObject.GetType().Name} of value {someObject.ToString()}";
        }

        // If the input is a different type,
        // this method should return null.

        return null;
    }
}
