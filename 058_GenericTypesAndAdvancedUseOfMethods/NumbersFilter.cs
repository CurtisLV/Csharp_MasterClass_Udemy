﻿public class Filter
{
    public IEnumerable<T> FilterBy<T>(Func<T, bool> predicate, IEnumerable<T> numbers)
    {
        var result = new List<T>();

        foreach (var i in numbers)
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
    public readonly Dictionary<string, Func<int, bool>> _filteringStrategies = new Dictionary<
        string,
        Func<int, bool>
    >()
    {
        ["Even"] = number => number % 2 == 0,
        ["Odd"] = number => number % 2 == 1,
        ["Positive"] = number => number > 0,
        ["Negative"] = number => number < 0
    };

    public IEnumerable<string> FilteringStrategiesNames => _filteringStrategies.Keys;

    public Func<int, bool> Select(string filteringType)
    {
        if (!_filteringStrategies.ContainsKey(filteringType))
        {
            throw new NotSupportedException($"{filteringType} is not a valid filter");
        }
        return _filteringStrategies[filteringType];
    }
}
