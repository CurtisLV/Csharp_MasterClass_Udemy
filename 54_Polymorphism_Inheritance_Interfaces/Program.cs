var pizza = new Pizza();
pizza.AddIngridients(new Cheddar());
pizza.AddIngridients(new Mozzarella());
pizza.AddIngridients(new TomatoSauce());

Console.ReadKey();

public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngridients(Ingredient ingredient) => _ingredients.Add(ingredient);

    public string Describe() => $"This is a pizza with {string.Join(", ", _ingredients)}";
}

public class Ingredient
{
    //
}

public class Cheddar : Ingredient
{
    public string Name => "Cheddar cheese";
    public int AgedForMonths { get; }
}

public class TomatoSauce : Ingredient
{
    public string Name => "Tomato sauce";
    public int TomatoesIn100Grams { get; }
}

public class Mozzarella : Ingredient
{
    public string Name => "Mozzarella";
    public bool IsLight { get; }
}
