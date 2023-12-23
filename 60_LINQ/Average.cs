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
            var orderedListOfNum = listOfNumbers
                .OrderByDescending(list => list.Average())
                .Select(list => $"{list.Count} {list.Average()}");
            Printer.Print(orderedListOfNum, nameof(orderedListOfNum));

            // Anonymous objects, they are read only so 2nd line does not work.
            var pet = new { Name = "Jackie", Type = "Dog" };
            //pet.Name = "Jack";
        }
    }
}
