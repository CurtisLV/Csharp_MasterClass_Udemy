using _60_LINQ.SampleData;
using _60_LINQ.Utilities;

namespace _60_LINQ;

static class Any
{
    public static void Run()
    {
        var numbers = new[] { 5, 9, 2, 12, 6 };
        bool isAnyLargerThan10 = numbers.Any(num => num > 10);

        var isAnyPetNamedBruce = Data.Pets.Any(pet => pet.Name == "Bruce");
        Printer.Print(isAnyPetNamedBruce, nameof(isAnyPetNamedBruce));

        var isAnyFish = Data.Pets.Any(pet => pet.PetType == PetType.Fish);
        Printer.Print(isAnyFish, nameof(isAnyFish));

        var isThereAVerySpecificPet = Data.Pets.Any(pet => pet.Name.Length > 6 && pet.Id % 2 == 0);
        Printer.Print(isThereAVerySpecificPet, nameof(isThereAVerySpecificPet));

        var isNotEmpty = Data.Pets.Any();
        Printer.Print(isNotEmpty, nameof(isNotEmpty));
    }
}
