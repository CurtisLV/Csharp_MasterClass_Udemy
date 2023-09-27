using _60_LINQ.SampleData;
using _60_LINQ.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60_LINQ;

static class Count
{
    public static void Run()
    {
        var pets = Data.Pets;

        var countOfDogs = pets.Count(pet => pet.PetType == PetType.Dog);
        Printer.Print(countOfDogs, nameof(countOfDogs));

        var countOfPetsNamedBruce = pets.LongCount(pet => pet.Name == "Bruce");
        Printer.Print(countOfPetsNamedBruce, nameof(countOfPetsNamedBruce));

        var countOfAllSmallDogs = pets.Count(pet => pet.PetType == PetType.Dog && pet.Weight < 10);
        Printer.Print(countOfAllSmallDogs, nameof(countOfAllSmallDogs));

        var countPets = pets.Count();
        Printer.Print(countPets, nameof(countPets));
    }
}
