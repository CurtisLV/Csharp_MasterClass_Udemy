namespace _55_CookieCookbook.Recipes.Ingredients;

public abstract class Ingredient
{
    public abstract int Id { get; }
    public abstract string Name { get; }
    public abstract string PreparationInstructions { get; }

    public override string ToString()
    {
        return $"{Name}. {PreparationInstructions} Add to other ingredients.";
    }
}
