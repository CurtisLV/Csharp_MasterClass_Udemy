using _60_LINQ.SampleData;
using _60_LINQ.Utilities;

namespace _60_LINQ;

static class OrderBy
{
    public static void Run()
    {
        var pets = Data.Pets;

        var petsOrderedByName = pets.OrderBy(pet => pet.Name);
        Printer.Print(petsOrderedByName, nameof(petsOrderedByName));

        var petsOrderedById = pets.OrderByDescending(pet => pet.Id);
        Printer.Print(petsOrderedById, nameof(petsOrderedById));

        var numbers = new[] { 16, -1, 3, 8, 5, 11, };
        var orderedNumbers = numbers.OrderBy(number => number);
        Printer.Print(orderedNumbers, nameof(orderedNumbers));

        var words = new[] { "lion", "tiger", "cow", "snow cow" };
        var orderedWordsDesc = words.OrderByDescending(word => word);
        Printer.Print(orderedWordsDesc, nameof(orderedWordsDesc));

        var petsOrderedByTypeThenName = pets.OrderBy(pet => pet.PetType).ThenBy(pet => pet.Name);
        Printer.Print(petsOrderedByTypeThenName, nameof(petsOrderedByTypeThenName));
    }
}
