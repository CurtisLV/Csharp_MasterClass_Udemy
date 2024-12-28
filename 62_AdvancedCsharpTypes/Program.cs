using System.ComponentModel.DataAnnotations;

var validPerson = new PersonToBeValidated("John", 1989);
var invalidDog = new Dog("F");

var validator = new Validator();

Console.WriteLine(validator.Validate(validPerson) ? "Person is valid" : "Person is invalid");
Console.WriteLine(validator.Validate(invalidDog) ? "Dog is valid" : "Dog is invalid");

var point = new Point(1, 3);
var anotherPoint = point;

anotherPoint.Y = 100;

//Point nullPoint = null;
Person person = new Person();

Console.WriteLine($"Point is {point}");
Console.WriteLine($"anotherPoint is {anotherPoint}");

SomeMethod(5);

//SomeMethod(new Person());

Console.ReadKey();

void SomeMethod<T>(T param)
    where T : struct // done so that this method now accepts only value types
{
    //
}

// Attributes

public class Dog
{
    [StringLengthValidate(2, 10)]
    public string Name { get; } // length must be between 2 and 10

    public Dog(string name) => Name = name;
}

public class PersonToBeValidated
{
    [StringLengthValidate(2, 25)]
    public string Name { get; } // length must be between 2 and 25
    public int YearOfBirth { get; }

    public PersonToBeValidated(string name, int age)
    {
        Name = name;
        YearOfBirth = age;
    }

    public PersonToBeValidated(string name) => Name = name;
}

[AttributeUsage(AttributeTargets.Property)]
class StringLengthValidateAttribute : Attribute
{
    public int Min { get; }
    public int Max { get; }

    public StringLengthValidateAttribute(int min, int max)
    {
        Min = min;
        Max = max;
    }
}

class Validator
{
    public bool Validate(object obj)
    {
        var type = obj.GetType();
        var propertiesToValidate = type.GetProperties()
            .Where(property =>
                Attribute.IsDefined(property, typeof(StringLengthValidateAttribute))
            );

        foreach (var property in propertiesToValidate)
        {
            object? propertyValue = property.GetValue(obj);
            if (propertyValue is not string)
            {
                throw new InvalidOperationException(
                    $"Attribute {nameof(StringLengthValidateAttribute)} can only be applied to strings"
                );
            }
            var value = (string)propertyValue;
            var attribute = (StringLengthValidateAttribute)
                property.GetCustomAttributes(typeof(StringLengthValidateAttribute), false).First();
            if (value.Length < attribute.Min || value.Length > attribute.Max)
            {
                Console.WriteLine($"Property {property.Name} is invalid. Value is {value}");
                return false;
            }
        }
        return true;
    }
}

[Some(new int[] { 1, 2, 3 })]
public class SomeClass
{
    //
}

public class SomeAttribute : Attribute
{
    public int[] Numbers { get; }

    public SomeAttribute(int[] numbers)
    {
        Numbers = numbers;
    }
}

// Structs

struct FishyStruct
{
    public List<int> Numbers { get; init; }
}

struct Point : IComparable<Point>
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Point() // omly from C# 10
    {
        X = 0;
        Y = 1;
    }

    public override string ToString()
    {
        return $"X: {X}, Y: {Y}";
    }

    public int CompareTo(Point other)
    {
        throw new NotImplementedException();
    }
}

class Person
{
    private Point _favouritePoint;
    private Person _favouritePerson;

    public int Id { get; init; }
    public string Name { get; init; }
}

// First exercise Attributes

[AttributeUsage(AttributeTargets.Property)]
public class MustBeLargerThanAttribute : Attribute
{
    public int Min { get; }

    public MustBeLargerThanAttribute(int min)
    {
        Min = min;
    }
}
