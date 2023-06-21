Console.ReadKey();

public class Pizza
{
    private List<string> _ingredients = new List<string>();

    public void AddIngridients(string ingredient) => _ingredients.Add(ingredient);

    public string Describe() => $"This is a pizza with {string.Join(", ", _ingredients)}";
}
