//var numbers = new List<int> { 1, 3, 1, 2, 41 };
//var words = new List<string> { "aaa", "bbb", "ccc" };
//var dates = new List<DateTime> { new DateTime(2023, 8, 31) };

var numbers = new ListOfInts();

numbers.Add(7);
numbers.Add(3);
numbers.Add(12);
numbers.Add(2);
numbers.Add(41);

Console.ReadKey();

class ListOfInts
{
    private int[] _items = new int[4];
    private int _size = 0;

    public void Add(int item)
    {
        if (_size >= _items.Length)
        {
            var newItems = new int[_items.Length * 2];

            for (int i = 0; i < _items.Length; i++)
            {
                newItems[i] = _items[i];
            }

            _items = newItems;
        }
        _items[_size] = item;
        ++_size;
    }
}
