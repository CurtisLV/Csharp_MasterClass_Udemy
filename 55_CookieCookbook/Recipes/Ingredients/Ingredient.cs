namespace _55_CookieCookbook.Recipes.Ingredients;

public abstract class Ingredient
{
    public abstract int Id { get; }
    public abstract string Name { get; }
    public abstract string Description { get; }

    public override string ToString()
    {
        return $"{Name}. {Description} Add to other ingredients.";
    }
}
