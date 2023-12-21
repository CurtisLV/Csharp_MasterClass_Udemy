using _60_LINQ.SampleData;
using _60_LINQ.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60_LINQ
{
    static class Distinct
    {
        public static void Run()
        {
            var pets = Data.Pets;
            var numbers = Data.numbers;

            var numbersNoDuplicates = numbers.Distinct();
            Printer.Print(numbersNoDuplicates, nameof(numbersNoDuplicates));
        }
    }
}
