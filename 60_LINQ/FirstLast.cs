using _60_LINQ.SampleData;
using _60_LINQ.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60_LINQ;

static class FirstLast
{
    public static void Run()
    {
        var pets = Data.Pets;
        var numbers = Data.numbers;

        var firstNumber = numbers.First();
        Printer.Print(firstNumber, nameof(firstNumber));

        var firstOddNumber = numbers.First(num => num % 2 == 1);
        Printer.Print(firstOddNumber, nameof(firstOddNumber));

        var lastDog = pets.Last(pet => pet.PetType == PetType.Dog);
        Printer.Print(lastDog, nameof(lastDog));

        //var lastPetHeavierThan100 = pets.Last(pet => pet.Weight > 100);
        var lastPetHeavierThan100 = pets.LastOrDefault(pet => pet.Weight > 100);
        Printer.Print(lastPetHeavierThan100, nameof(lastPetHeavierThan100));
    }
}
