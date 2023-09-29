using _60_LINQ.SampleData;
using _60_LINQ.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
