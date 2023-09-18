﻿public class NumbersFilter
{
    public List<int> FilterBy(Func<int, bool> predicate, List<int> numbers)
    {
        var result = new List<int>();

        foreach (int i in nums)
        {
            if (predicate(i))
            {
                result.Add(i);
            }
        }

        return result;
    }
}

public class FilteringStrategySelector
{
    public Func<int, bool> Select(string filteringType)
    {
        switch (filteringType)
        {
            case "Even":
                return number => number % 2 == 0;
            case "Odd":
                return number => number % 2 == 1;
            case "Positive":
                return number => number > 0;
            default:
                throw new NotSupportedException($"{filteringType} is not a valid filter");
        }
    }
}