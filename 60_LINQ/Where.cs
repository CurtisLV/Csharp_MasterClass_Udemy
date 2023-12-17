using _60_LINQ.SampleData;
using _60_LINQ.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60_LINQ
{
    static class Where
    {
        public static void Run()
        {
            var pets = Data.Pets;
            var numbers = Data.numbers;

            var evenNumbers = numbers.Where(num => num % 2 == 0);
            Printer.Print(evenNumbers, nameof(evenNumbers));

            var heavierThan10Kilos = pets.Where(pet => pet.Weight > 10);
            Printer.Print(heavierThan10Kilos, nameof(heavierThan10Kilos));

            var heavierThan100Kilos = pets.Where(pet => pet.Weight > 100);
            Printer.Print(heavierThan100Kilos, nameof(heavierThan100Kilos));

            // cats or dogs, name over 4 letters, w 10k and even id
            var verySpecificPets = pets.Where(
                    pet => pet.PetType == PetType.Cat || pet.PetType == PetType.Dog
                )
                .Where(pet => pet.Weight >= 10)
                .Where(pet => pet.Id % 2 == 0);

            Printer.Print(verySpecificPets, nameof(verySpecificPets));

            // where pet is below 5kg and also id selected

            var indexesSelectedByUser = new[] { 1, 6, 7 };
            var petsSelectedByUserAndLighterThank5k = pets.Where(
                (pet, petIndex) => pet.Weight < 5 && indexesSelectedByUser.Contains(petIndex)
            );

            Printer.Print(
                petsSelectedByUserAndLighterThank5k,
                nameof(petsSelectedByUserAndLighterThank5k)
            );

            int countOfHeavyPets1 = pets.Count(pet => pet.Weight > 30);
            int countOfHeavyPets2 = pets.Where(pet => pet.Weight > 30).Count();

            Printer.Print(countOfHeavyPets1, nameof(countOfHeavyPets1));
            Printer.Print(countOfHeavyPets2, nameof(countOfHeavyPets2));
        }
    }
}
