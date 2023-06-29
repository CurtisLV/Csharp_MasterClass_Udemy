using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_Polymorphism_Inheritance_Interfaces.NumberSumCalc
{
    internal class NumberSumCalculator
    {
        var numbers = new List<int> { 1, 4, 6, -1, 12, 44, -8, -19 };
        bool shallAddPositiveOnly = false;

        NumbersSumCalculator calculator = shallAddPositiveOnly
            ? new PositiveNumbersSumCalculator()
            : new NumbersSumCalculator();

        int sum;
        if (shallAddPositiveOnly)
        {
            sum = new PositiveNumbersSumCalculator().Calculate(numbers);
    }
        else
        {
            sum = new NumbersSumCalculator().Calculate(numbers);
}

Console.WriteLine($"Sum is {sum}");
Console.ReadKey();

public class NumbersSumCalculator
{
    public int Calculate(List<int> numbers)
    {
        int sum = 0;
        foreach (var num in numbers)
        {
            if (ShallBeAdded(num))
            {
                sum += num;
            }
        }
        return sum;
    }

    protected virtual bool ShallBeAdded(int num)
    {
        return true;
    }
}

public class PositiveNumbersSumCalculator : NumbersSumCalculator
{
    protected override bool ShallBeAdded(int num)
    {
        return num > 0;
    }
}
    }
}
