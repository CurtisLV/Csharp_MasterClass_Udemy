//int number = 5;
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
