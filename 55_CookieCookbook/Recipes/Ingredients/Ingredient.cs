public abstract class Ingredient
{
    public abstract int Id { get; }
    public abstract string Name { get; }
    public string Description { get; set; }

    public override string ToString()
    {
        return $"{Name}. {Description} Add to other ingredients.";
    }
}
