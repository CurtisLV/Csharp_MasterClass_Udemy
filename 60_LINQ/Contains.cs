using _60_LINQ.SampleData;
using _60_LINQ.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60_LINQ;

static class Contains
{
    public static void Run()
    {
        var pets = Data.Pets;

        var numbers = new[] { 16, -1, 3, 8, 5, 11, };
        bool is7Present = numbers.Contains(7);
        Printer.Print(is7Present, nameof(is7Present));

        var words = new[] { "lion", "tiger", "cow", "snow cow" };
        bool isCowPresent = words.Contains("cow");
        Printer.Print(isCowPresent, nameof(isCowPresent));
    }
}
