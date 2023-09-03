using System.Collections;

var numbers = new SimpleList<int>();
numbers.Add(10);
numbers.Add(20);
numbers.Add(30);
numbers.Add(40);
numbers.Add(50);
numbers.RemoveAt(2);

var words = new SimpleList<string>();
words.Add("aaa");
words.Add("bbb");
words.Add("ccc");

var dates = new SimpleList<DateTime>();
dates.Add(new DateTime(2023, 9, 1));
dates.Add(new DateTime(2023, 9, 2));
dates.Add(new DateTime(2023, 9, 3));

var numbaz = new List<int> { 5, 3, 2, 8, 16, 7, -9, -12, 16 };
Tuple<int, int> minAndMax = GetMinMax(numbaz);

var twoStrings = new Tuple<string, string>("aaa", "bbb");
var differentTypes = new Tuple<string, int>("aaa", 7);
var threeItems = new Tuple<string, int, bool>("aaa", 7, false);

Console.WriteLine("Smallest number is " + minAndMax.Item1);
Console.WriteLine("Largest number is " + minAndMax.Item2);

// ArrayLists - they suck!
ArrayList ints = new ArrayList { 2, 3, 4, 5, };
ArrayList strings = new ArrayList { "a", "b", "c", "d" };
ArrayList variousItems = new ArrayList { 1, false, "abc", new DateTime() };

// Generic methods

numbaz.AddToFront(10);
numbaz.AddToFront<int>(11);
numbaz.AddToFront<int>("abc");

Console.ReadKey();

Tuple<int, int> GetMinMax(IEnumerable<int> input)
{
    if (!input.Any())
    {
        throw new InvalidOperationException($"The input collection cannot be empty");
    }

    int min = input.First();
    int max = input.First();

    foreach (var num in numbaz)
    {
        if (num > max)
        {
            max = num;
        }

        if (num < min)
        {
            min = num;
        }
    }

    return new Tuple<int, int>(min, max);
}

static class ListExtensions
{
    public static void AddToFront<T>(this List<T> list, T value)
    {
        list.Insert(0, value);
    }
}

// First coding exercise
public class Pair<T>
{
    public T First { get; private set; }
    public T Second { get; private set; }

    public Pair(T first, T second)
    {
        First = first;
        Second = second;
    }

    public void ResetFirst()
    {
        First = default;
    }

    public void ResetSecond()
    {
        Second = default;
    }
}
