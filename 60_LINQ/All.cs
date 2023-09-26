using _60_LINQ.SampleData;
using _60_LINQ.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60_LINQ;

static class All
{
    public static void Run()
    {
        var numbers = new[] { 5, 9, 2, 12, 6 };
        var areAllLargerThanZero = numbers.All(number => number > 0);
        Printer.Print(areAllLargerThanZero, nameof(areAllLargerThanZero));

        var pets = Data.Pets;

        var doAllHaveNonEmptyNames = pets.All(pet => pet.Name != null);
        Printer.Print(doAllHaveNonEmptyNames, nameof(doAllHaveNonEmptyNames));
    }
}
