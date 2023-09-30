using _60_LINQ.SampleData;
using _60_LINQ.Utilities;

namespace _60_LINQ;

static class All
{
    public static void Run()
    {
        var numbers = new[] { 5, 9, 2, 12, 6 };
        var areAllLargerThanZero = numbers.All(number => number > 0);
        Printer.Print(areAllLargerThanZero, nameof(areAllLargerThanZero));

        var pets = Data.Pets;

        var doAllHaveNonEmptyNames = pets.All(pet => !string.IsNullOrEmpty(pet.Name));
        Printer.Print(doAllHaveNonEmptyNames, nameof(doAllHaveNonEmptyNames));

        var areAllCats = pets.All(pet => pet.PetType == PetType.Cat);
        Printer.Print(areAllCats, nameof(areAllCats));
    }
}
