//var numbers = new List<int> { 1, 3, 1, 2, 41 };
//var words = new List<string> { "aaa", "bbb", "ccc" };
//var dates = new List<DateTime> { new DateTime(2023, 8, 31) };

Console.ReadKey();

class ListOfInts
{
    private int[] _items = new int[4];
    private int _size = 0;

    public void Add(int item)
    {
        if (_size > _items.Length)
        {
            var newItems = new int[_items.Length * 2];

            for (int i = 0; i < _items.Length; i++)
            {
                newItems[i] = _items[i];
            }
        }
        _items[0] = item;
        ++_size;
    }
}
