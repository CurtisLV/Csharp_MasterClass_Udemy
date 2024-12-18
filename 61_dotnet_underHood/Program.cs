using System.Collections;
using _61_dotnet_underHood;

const string filepath = "file.txt";

using (var writer = new FileWriter(filepath))
{
    writer.Write("Hello, World!");
    writer.Write("Good day to be alive!");
}

using var reader = new SpecificLineFromTextFileReader(filepath);

var third = reader.ReadLineNumber(3);
var fourth = reader.ReadLineNumber(4);
Console.WriteLine($"Content of third line: {third}");
Console.WriteLine($"Content of fourth line: {fourth}");

int number = 5;

//var john = new Person { Name = "John", Age = 35 };

//AddOneToValue(ref number);
//AddOneToPerson(john);

//Console.WriteLine("This is number " + number);
//Console.WriteLine("This is person " + john.Age);

//int otherNumber = 15;

//MethodWithOutParameter(out otherNumber);
//Console.WriteLine("Other number is " + otherNumber);

////DateTime today;

//DateTime today = new DateTime(2024, 2, 24);
//RefModifierFastForwardToSummerExercise.FastForwardToSummer(ref today);
//Console.WriteLine("Today is " + today);

bool someCondition = true;

if (someCondition)
{
    var someClassInstance = new SomeClass();
}

Console.WriteLine($"Count of all instances is now {SomeClass.CountOfInstances}");

for (var i = 0; i < 5; i++)
{
    var person = new Person { Name = "Vārds", Age = 35 };
}

//GC.Collect();

object boxedNumber = number;
int unboxedNumber = (int)boxedNumber;

IComparable<int> intAsComparble = number;

var numbers1 = new List<int> { 1, 2, 3, 4, 5 };
var numbers2 = new ArrayList { 1, 2, 3, 4, 5 };

var numbers3 = new List<IComparable<int>> { 1, 2, 3, 4, 5 };

var variousObjects = new List<object>
{
    1,
    1.5m,
    new DateTime(2024, 6, 1),
    "hello",
    new Person { Name = "Anna", Age = 61 }
};

foreach (object someObj in variousObjects)
{
    Console.WriteLine(someObj.GetType().Name);
}

var list = new List<int> { 1, 2, 3 };

AddOneToList(ref list);

void AddOneToList(ref List<int> numbers)
{
    numbers.Add(1);
}

void MethodWithOutParameter(out int number)
{
    number = 10;
}

void AddOneToValue(ref int number)
{
    ++number;
}

void AddOneToPerson(Person person)
{
    ++person.Age;
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    ~Person()
    {
        Console.WriteLine($"Person named {Name} is being destructed.");
    }
}

public class SomeClass
{
    private static List<SomeClass> _allExistingInstances = new List<SomeClass>();

    public static int CountOfInstances => _allExistingInstances.Count;

    public SomeClass()
    {
        _allExistingInstances.Add(this);
    }
}

// Coding exercise 1

public class RefModifierFastForwardToSummerExercise
{
    public static void FastForwardToSummer(ref DateTime date)
    {
        var firstDateOfSummer = new DateTime(date.Year, 6, 21);
        if (date < firstDateOfSummer)
        {
            date = firstDateOfSummer;
        }
    }
}

// Coding exercise 2

public class AllLinesFromTextFileReader : IDisposable
{
    private readonly StreamReader _streamReader;

    public AllLinesFromTextFileReader(string filePath)
    {
        _streamReader = new StreamReader(filePath);
    }

    public List<string> ReadAllLines()
    {
        var result = new List<string>();
        while (!_streamReader.EndOfStream)
        {
            result.Add(_streamReader.ReadLine());
        }

        return result;
    }

    public void Dispose()
    {
        _streamReader.Dispose(); 
    }
}
