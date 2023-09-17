public class NumbersFilter
{
    public List<int> FilterBy(string filteringType, List<int> numbers)
    {
        switch (filteringType)
        {
            case "Even":
                return SelectEven(numbers);
            case "Odd":
                return SelectOdd(numbers);
            case "Positive":
                return SelectPositive(numbers);
            default:
                throw new NotSupportedException($"{filteringType} is not a valid filter");
        }
    }

    private List<int> SelectPositive(List<int> nums)
    {
        var result = new List<int>();

        foreach (int i in nums)
        {
            if (i > 0)
            {
                result.Add(i);
            }
        }

        return result;
    }

    private List<int> SelectOdd(List<int> nums)
    {
        var result = new List<int>();

        foreach (int i in nums)
        {
            if (i % 2 == 1)
            {
                result.Add(i);
            }
        }

        return result;
    }

    private List<int> SelectEven(List<int> nums)
    {
        var result = new List<int>();

        foreach (int i in nums)
        {
            if (i % 2 == 0)
            {
                result.Add(i);
            }
        }

        return result;
    }

    private List<int> Select(List<int> nums)
    {
        var result = new List<int>();

        foreach (int i in nums)
        {
            if (i % 2 == 0)
            {
                result.Add(i);
            }
        }

        return result;
    }
}
