int seasonNumber = 0;
Season spring = (Season)seasonNumber;

decimal a = 10.01m;
int integer = 10;
decimal b = integer;

Console.ReadKey();

public enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}

//var pizza = new Pizza();
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

//var cheddar = new Cheddar(2, 2);
//Console.WriteLine(cheddar);
//Console.ReadKey();

//var ingredients = new List<Ingredient> { new Cheddar(), new Mozzarella(), new TomatoSauce() };

//foreach (var ingredient in ingredients)
//{
//    Console.WriteLine(ingredient.Name);
//}

public class Pizza
{
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
