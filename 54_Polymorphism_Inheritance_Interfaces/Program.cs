﻿//var numbers = new List<int> { 1, 4, 6, -1, 12, 44, -8, -19 };
//bool shallAddPositiveOnly = false;

//NumbersSumCalculator calculator = shallAddPositiveOnly
//    ? new PositiveNumbersSumCalculator()
//    : new NumbersSumCalculator();

//int sum;
//if (shallAddPositiveOnly)
//{
//    sum = new PositiveNumbersSumCalculator().Calculate(numbers);
//}
//else
//{
//    sum = new NumbersSumCalculator().Calculate(numbers);
//}

//Console.WriteLine($"Sum is {sum}");
//Console.ReadKey();

//public class NumbersSumCalculator
//{
//    public int Calculate(List<int> numbers)
//    {
//        int sum = 0;
//        foreach (var num in numbers)
//        {
//            if (ShallBeAdded(num))
//            {
//                sum += num;
//            }
//        }
//        return sum;
//    }

//    protected virtual bool ShallBeAdded(int num)
//    {
//        return true;
//    }
//}

//public class PositiveNumbersSumCalculator : NumbersSumCalculator
//{
//    protected override bool ShallBeAdded(int num)
//    {
//        return num > 0;
//    }
//}

var pizza = new Pizza();
pizza.AddIngridients(new Cheddar());
pizza.AddIngridients(new Mozzarella());

pizza.AddIngridients(new TomatoSauce());

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

var cheddar = new Cheddar();
Console.WriteLine(cheddar + " this");

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

    public string PublicMethod() => "This method is PUBLIC in the Ingredient class";

    protected string ProtectedMethod() => "This method is PROTECTED in the Ingredient class";

    private string PrivateMethod() => "This method is PRIVATE in the Ingredient class";
}

public class Cheese : Ingredient
{
    //
}

public class Cheddar : Cheese
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

public class Mozzarella : Cheese
{
    public override string Name => "Mozzarella";
    public bool IsLight { get; }
}
