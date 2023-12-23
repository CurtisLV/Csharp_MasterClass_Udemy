using _60_LINQ.SampleData;
using _60_LINQ.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60_LINQ
{
    static class Average
    {
        public static void Run()
        {
            var pets = Data.Pets;
            var numbers = Data.numbers;
            var listOfNumbers = Data.listOfNumbers;

            // print info count of items and average value, msg ordered by max average to small.
            var orderedListOfNum = 1;
            Printer.Print(orderedListOfNum, nameof(orderedListOfNum));
        }
    }
}
