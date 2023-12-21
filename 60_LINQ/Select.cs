using _60_LINQ.SampleData;
using _60_LINQ.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60_LINQ
{
    static class Select
    {
        public static void Run()
        {
            var pets = Data.Pets;
            var numbers = Data.numbers;

            var doubledNumbers = numbers.Select(num => num * 2);
            Printer.Print(doubledNumbers, nameof(doubledNumbers));

            var words = new[] { "little", "brown", "fox" };
            var toUpperCase = words.Select(word => word.ToUpper());
            Printer.Print(words, nameof(words));
        }
    }
}
