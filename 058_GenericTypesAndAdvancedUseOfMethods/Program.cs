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

//List<Employee> employees = new List<Employee>
//{
//    new Employee { Name = "Eve", YearOfBirth = 1993 },
//    new Employee { Name = "Frank", YearOfBirth = 1988 }
//};

//var validPeople = GetOnlyValid(people);
//var validEmployees = GetOnlyValid(employees);

//foreach (var emp in validEmployees)
//{
//    //emp.GoToWork(); // doesn't work when GetOnlyValid() returns Person class
//    //((Employee)emp).GoToWork(); // works but clouds code and worse performance
//    emp.GoToWork(); // we changed Person class to accept generics
//}

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

//Func<int, bool> predicate1 = IsLargerThan10;
//Func<int, bool> predicate2 = IsEven;

//Console.WriteLine("Is larger than 10?" + IsAny((IEnumerable<int>)numbers, n => n > 10));
//Console.WriteLine("Is any even?" + IsAny((IEnumerable<int>)numbers, n => n % 2 == 0));

Func<int, DateTime, string, decimal> someFunc; // when we want something returned - last parameter is always return parameter
Action<string, string, bool> someAction; // when want VOID returned, so all parameters are input

var countryToCurrencyMapping = new Dictionary<string, string>()
{
    ["USA"] = "USD",
    ["Spain"] = "EUR",
    ["Poland"] = "PLN"
};

// Alternative syntax to the above
var countryToCurrencyMappingOldWay = new Dictionary<string, string>()
{
    { "USA", "USD" },
    { "Spain", "EUR" },
    { "Poland", "PLN" }
};

//
//countryToCurrencyMapping.Add("USA", "USD");
//countryToCurrencyMapping.Add("Latvia", "EUR");
//countryToCurrencyMapping.Add("Italy", "EUR");
//countryToCurrencyMapping.Add("India", "INR");

countryToCurrencyMapping["Poland"] = "PLN";
Console.WriteLine($"Currency in Poland is {countryToCurrencyMapping["Poland"]}");
if (countryToCurrencyMapping.ContainsKey("Italy"))
{
    Console.WriteLine($"Currency in Italy is {countryToCurrencyMapping["Italy"]}");
}

foreach (var countryCurrencyPair in countryToCurrencyMapping)
{
    Console.WriteLine($"Country: {countryCurrencyPair.Key}, Currency: {countryCurrencyPair.Value}");
}

List<Employee> employeesDict = new List<Employee>
{
    new Employee("Jake Smith", "Space Navigation", 25000),
    new Employee("Jane Smith", "Space Navigation", 22000),
    new Employee("Emily Johnson", "IT", 28000),
    new Employee("Michael Brown", "Engineering", 32000),
    new Employee("Sarah Wilson", "Engineering", 24000),
    new Employee("David Lee", "IT", 27000)
};

var result = CalculateAverageSalaryPerDepartment(employeesDict);

var nums = new List<int> { 10, 12, -100, 55, 17, 22 };
var filteringStrategySelector = new FilteringStrategySelector();

Console.WriteLine("Select filter:");
Console.WriteLine(
    string.Join(Environment.NewLine, filteringStrategySelector.FilteringStrategiesNames)
);

var userInput = Console.ReadLine();

var filteringStrategy = new FilteringStrategySelector().Select(userInput);
var result2 = new Filter().FilterBy(filteringStrategy, nums);

Print(result2);

var words3 = new[] { "zebra", "yolo", "opupedis" };
var oWords = new Filter().FilterBy(word => word.StartsWith("o"), words3);

var dataDownloader = new SlowDataDownloader();

Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id2"));
Console.WriteLine(dataDownloader.DownloadData("id3"));
Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id3"));
Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id2"));

Print(oWords);

Console.ReadKey();

void Print<T>(IEnumerable<T> numbers)
{
    Console.WriteLine(string.Join(", ", numbers));
}

Dictionary<string, decimal> CalculateAverageSalaryPerDepartment(IEnumerable<Employee> employees)
{
    var employeesPerDepartment = new Dictionary<string, List<Employee>>();

    foreach (var emp in employees)
    {
        if (!employeesPerDepartment.ContainsKey(emp.Department))
        {
            employeesPerDepartment[emp.Department] = new List<Employee>();
        }
        employeesPerDepartment[emp.Department].Add(emp);
    }

    var result = new Dictionary<string, decimal>();

    foreach (var empl in employeesPerDepartment)
    {
        decimal sumOfAvgSalary = default;
        foreach (var e in empl.Value)
        {
            sumOfAvgSalary += e.MonthlySalary;
        }
        sumOfAvgSalary = Math.Round(sumOfAvgSalary / empl.Value.Count, 2);

        //result.Add(empl.Key, sumOfAvgSalary);
        result[empl.Key] = sumOfAvgSalary;
    }

    return result;
}

bool IsAny(IEnumerable<int> numbers, Func<int, bool> predicate)
{
    foreach (var number in numbers)
    {
        if (predicate(number))
        {
            return true;
        }
    }
    return false;
}

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

// Delegates + multicast delegates
ProcessString processString1 = TrimTo5Letters;
ProcessString processString2 = ToUpper;
Console.WriteLine(processString1("JohnSmith"));
Console.WriteLine(processString2("JohnSmith"));

string TrimTo5Letters(string input)
{
    return input.Substring(0, 5);
}

string ToUpper(string input)
{
    return input.ToUpper();
}

Print print1 = text => Console.WriteLine(text.ToUpper());
Print print2 = text => Console.WriteLine(text.ToLower());
Print multicast = print1 + print2;
Print print4 = text => Console.WriteLine(text.Substring(0, 3));
multicast += print4;
multicast("Zilonis");

Func<string, string, int> sumLenghts = (text1, text2) => SumLengths(text1, text2);

int SumLengths(string text1, string text2)
{
    return text1.Length + text2.Length;
}

delegate string ProcessString(string input);
delegate void Print(string input);

// caching
class SlowDataDownloader : IDataDownloader
{
    public SlowDataDownloader()
    {
        //
    }

    public string DownloadData(string resourceId)
    {
        throw new NotImplementedException();
    }
}

internal interface IDataDownloader
{
    string DownloadData(string resourceId);
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

public class Employee //: Person
{
    public string Name { get; init; }
    public string Department { get; init; }
    public decimal MonthlySalary { get; init; }

    public Employee(string name, string department, decimal monthlySalary)
    {
        Name = name;
        Department = department;
        MonthlySalary = monthlySalary;
    }

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

// Fourth coding exercise
public class Exercise4
{
    public void TestMethod()
    {
        Func<int, bool, double> meth1 = Method1;

        Func<DateTime> meth2 = Method2;

        Action<string, string> action1 = Method3;
    }

    public double Method1(int a, bool b) => 0;

    public DateTime Method2() => default(DateTime);

    public void Method3(string a, string b) { }
}

// Fifth coding exercise
public class Exercise5
{
    public Func<string, int> GetLength = f => f.Length;
    public Func<int> GetRandomNumberBetween1And10 = () => new Random().Next(1, 11);
}

// Sith coding exercise
namespace Coding.Exercise6
{
    public static class Exercise
    {
        public static Dictionary<PetType, double> FindMaxWeights(List<Pet> pets)
        {
            var petsPerType = new Dictionary<PetType, List<Pet>>();

            foreach (var pet in pets)
            {
                if (!petsPerType.ContainsKey(pet.PetType))
                {
                    petsPerType[pet.PetType] = new List<Pet>();
                }
                petsPerType[pet.PetType].Add(pet);
            }

            var result = new Dictionary<PetType, double>();

            foreach (var petPerType in petsPerType)
            {
                double maxWeightPerType = petPerType.Value.Max(x => x.Weight);
                result.Add(petPerType.Key, maxWeightPerType);
            }

            return result;
        }
    }

    public class Pet
    {
        public PetType PetType { get; }
        public double Weight { get; }

        public Pet(PetType petType, double weight)
        {
            PetType = petType;
            Weight = weight;
        }

        public override string ToString() => $"{PetType}, {Weight} kilos";
    }

    public enum PetType
    {
        Dog,
        Cat,
        Fish
    }
}
