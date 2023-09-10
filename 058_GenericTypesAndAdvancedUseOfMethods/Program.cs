using System.Collections;
using System.Diagnostics;
using System.Numerics;

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
numbaz.AddToFront<int>(11); // no need to use <int>

//numbaz.AddToFront<int>("abc");

var decimals = new List<decimal> { 1.1m, 0.5m, 22.5m, 12m };
var integers = decimals.ConvertTo<decimal, int>();

var floats = new List<float> { 1.5f, -10.2f, 123.12f };
var longs = floats.ConvertTo<float, long>();

//var points = CreateCollectionOfRandomLenght<Point>(2);
var intss = CreateCollectionOfRandomLenght<int>(2);

Stopwatch stopwatch = Stopwatch.StartNew();

var dates2 = CreateCollectionOfRandomLenght<DateTime>(0);
stopwatch.Stop();
Console.WriteLine($"Execution took {stopwatch.ElapsedMilliseconds} milliseconds.");

List<Person> people = new List<Person>
{
    new Person { Name = "Alice", YearOfBirth = 1990 },
    new Person { Name = "Bob", YearOfBirth = 1985 },
    new Person { Name = "Charlie", YearOfBirth = -2000 },
    new Person { Name = null, YearOfBirth = 1995 },
    new Person { Name = "DavidDavidDavidDavidDavidDavidDavidDavidDavidDavid", YearOfBirth = 2000 },
    new Person { Name = "$%& John", YearOfBirth = 1980 }
};

List<Employee> employees = new List<Employee>
{
    new Employee { Name = "Eve", YearOfBirth = 1993 },
    new Employee { Name = "Frank", YearOfBirth = 1988 }
};

var validPeople = GetOnlyValid(people);
var validEmployees = GetOnlyValid(employees);

foreach (var emp in validEmployees)
{
    //emp.GoToWork(); // doesnt work when GetOnlyValid() returns Person class
    //((Employee)emp).GoToWork(); // works but clouds code and worse performance
    emp.GoToWork(); // we changed Person class to accept generics
}

numbaz.Sort();

List<string> words2 = new List<string> { "ccc", "ddd", "aaa" };
words2.Sort();
people.Sort();

var john = new Person { Name = "John", YearOfBirth = 1955 };
var anna = new Person { Name = "Anna", YearOfBirth = 1976 };

PrintInOrder(10, 5);
PrintInOrder("aaa", "bbb");
PrintInOrder(anna, john);

Console.WriteLine($"Square of 2 is {Calculator.Square(2)}");
Console.WriteLine($"Square of 4m is {Calculator.Square(4m)}");
Console.WriteLine($"Square of 6d is {Calculator.Square(6d)}");

Console.WriteLine("Is larger than 10?" + IsAnyLargerThan10((IEnumerable<int>)numbers));
Console.WriteLine("Is any even?" + IsAnyEven((IEnumerable<int>)numbers));

Func<int, DateTime, string, decimal> someFunc; // when we want somethign returned - last parameter is always return parameter
Action<string, string, bool> someAction;

Console.ReadKey();

bool IsAny(IEnumerable<int> numbers, Func<int, bool> predicate)
{
    foreach (var number in numbers)
    {
        if (number > 10)
        {
            return true;
        }
    }
    return false;
}

//bool IsAnyEven(IEnumerable<int> numbers)
//{
//    foreach (var number in numbers)
//    {
//        if (number % 2 == 0)
//        {
//            return true;
//        }
//    }
//    return false;
//}

void SomeMethod<TPet, TOwner>(TPet pet, TOwner owner)
    where TPet : Pet, IComparable<TPet>, new()
    where TOwner : new()
{
    //
}

void PrintInOrder<T>(T first, T second)
    where T : IComparable<T>
{
    if (first.CompareTo(second) > 0) // 1 means first is larger than second
    {
        Console.WriteLine($"{second} {first}");
    }
    else
    {
        Console.WriteLine($"{first} {second}");
    }
}

// Type constraints
IEnumerable<TPerson> GetOnlyValid<TPerson>(IEnumerable<TPerson> persons)
    where TPerson : Person
{
    var result = new List<TPerson>();
    foreach (var person in persons)
    {
        if (person.YearOfBirth > 1900 && person.YearOfBirth < DateTime.Now.Year)
        {
            result.Add(person);
        }
    }
    return result;
}

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

IEnumerable<T> CreateCollectionOfRandomLenght<T>(int maxLength)
    where T : new()
{
    var length = 1_000_000_00;
    //var length = new Random().Next(maxLength + 1);
    var point = new Point(1, 2);
    var result = new List<T>(length);

    for (int i = 0; i < length; ++i)
    {
        result.Add(new T());
    }

    return result;
}

// Type constraints - numeric types. General math.

public static class Calculator
{
    public static T Square<T>(T input)
        where T : INumber<T>
    {
        return input * input;
    }
}

// Type constraints - multiple constraints

public class Pet { }

public class PetOwner { }

public class Person : IComparable<Person>
{
    public string Name { get; init; }
    public int YearOfBirth { get; init; }

    public int CompareTo(Person other)
    {
        if (YearOfBirth < other.YearOfBirth)
        {
            return 1;
        }
        else if (YearOfBirth > other.YearOfBirth)
        {
            return -1;
        }
        return 0;
    }

    public override string ToString()
    {
        return $"{Name} born in {YearOfBirth}";
    }
}

public class Employee : Person
{
    public void GoToWork() => Console.WriteLine("Going to work!");
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

public class Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

// Second coding exercise
public static class TupleSwapExercise
{
    public static Tuple<TSecond, TFirst> SwapTupleItems<TFirst, TSecond>(
        Tuple<TFirst, TSecond> input
    )
    {
        return new Tuple<TSecond, TFirst>(input.Item2, input.Item1);
    }
}

// Third coding exercise
public class SortedList<T>
    where T : IComparable<T>
{
    public IEnumerable<T> Items { get; }

    public SortedList(IEnumerable<T> items)
    {
        var asList = items.ToList();
        asList.Sort();
        Items = asList;
    }
}

public class FullName : IComparable<FullName>
{
    public string FirstName { get; init; }
    public string LastName { get; init; }

    public int CompareTo(FullName other)
    {
        int lastNameComparison = string.Compare(LastName, other.LastName);
        int firstNameComparison = string.Compare(FirstName, other.FirstName);

        if (lastNameComparison != 0)
        {
            return lastNameComparison;
        }
        else
        {
            return firstNameComparison;
        }
    }

    public override string ToString() => $"{FirstName} {LastName}";
}
