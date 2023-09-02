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
SimpleTuple<int, int> minAndMax = GetMinMax(numbaz);
Console.WriteLine("Smallest number is " + minAndMax.Item1);
Console.WriteLine("Largest number is " + minAndMax.Item2);

Console.ReadKey();

SimpleTuple<int, int> GetMinMax(IEnumerable<int> input)
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

    return new SimpleTuple<int, int>(min, max);
}

public class SimpleTuple<T1, T2>
{
    public SimpleTuple(T1 item1, T2 item2)
    {
        Item1 = item1;
        Item2 = item2;
    }

    public T1 Item1 { get; }
    public T2 Item2 { get; }
}

class SimpleList<T>
{
    private T[] _items = new T[4];
    private int _size = 0;

    public void Add(T item)
    {
        if (_size >= _items.Length)
        {
            var newItems = new T[_items.Length * 2];

            for (int i = 0; i < _items.Length; i++)
            {
                newItems[i] = _items[i];
            }

            _items = newItems;
        }
        _items[_size] = item;
        ++_size;
    }

    public void RemoveAt(int index)
    {
        // making sure that the index is valid, it should be between zero and the size of the list
        if (index < 0 || index >= _size)
        {
            throw new IndexOutOfRangeException(
                $"Index {index} is outside of the bounds of the list."
            );
        }

        --_size;

        for (int i = index; i < _size; ++i)
        {
            _items[i] = _items[i + 1];
        }

        _items[_size] = default;
    }

    public T GetAtIndex(int index)
    {
        if (index < 0 || index >= _size)
        {
            throw new IndexOutOfRangeException(
                $"Index {index} is outside of the bounds of the list."
            );
        }
        return _items[index];
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
