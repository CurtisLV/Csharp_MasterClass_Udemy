static class ListExtensions
{
    public static List<TTarget> ConvertTo<TSource, TTarget>(this List<TSource> decimals)
    {
        var result = new List<TTarget>();

        foreach (var item in decimals)
        {
            TTarget itemAfterCasting = (TTarget)Convert.ChangeType(item, typeof(TTarget));
            result.Add(itemAfterCasting);
        }

        return result;
    }

    public static void AddToFront<T>(this List<T> list, T value)
    {
        list.Insert(0, value);
    }
}
