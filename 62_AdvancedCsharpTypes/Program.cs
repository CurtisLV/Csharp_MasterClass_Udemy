﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

var validPerson = new PersonToBeValidated("John", 1989);
var invalidDog = new Dog("F");

var validator = new Validator();

Console.WriteLine(validator.Validate(validPerson) ? "Person is valid" : "Person is invalid");
Console.WriteLine(validator.Validate(invalidDog) ? "Dog is valid" : "Dog is invalid");

var point = new Point(1, 3);
var anotherPoint = point;

//anotherPoint.Y = 100; // gives error because Y is immutable

var pointImmutableExample = new Point(10, 20);

MoveToRightBy1Unit(ref pointImmutableExample);

var dateTime = new DateTime(2025, 1, 6);
var dateWeekAfter = dateTime.AddDays(7);

//Non-destructive Mutation of struct
var pointNonDestructiveMutation = new Point(10, 20);
var pointMoved = pointNonDestructiveMutation with { X = 11 };
var pointMoved2 = pointNonDestructiveMutation with { X = pointNonDestructiveMutation.X + 1 }; // second way to do it

// non destructive mutation works with structs, recods, record structs and anonymous types
var pet = new { Name = "Han", Type = "Fish" };
var asCrab = pet with { Type = "Crab" };

void MoveToRightBy1Unit(ref Point pointImmutableExample)
{
    // move to right by one
    //pointImmutableExample.X++; // gives error because X is immutable
}

//Point nullPoint = null;
Person person = new Person();

Console.WriteLine($"Point is {point}");
Console.WriteLine($"anotherPoint is {anotherPoint}");

SomeMethod(5);

//SomeMethod(new Person());


var john = new Person(1, "John");
var sameAsJohn = new Person(1, "John");
var alsoSameAsJohn = john;

Console.WriteLine("Are references equal? " + object.ReferenceEquals(john, sameAsJohn));
Console.WriteLine("Are references equal? " + object.ReferenceEquals(john, alsoSameAsJohn));

Console.WriteLine("Are references equal for value types? " + object.ReferenceEquals(1, 1)); // will return false because each value is boxed separately before evaluated. See the green underline

Console.WriteLine("Are references equal for value types? " + object.ReferenceEquals(null, null)); // Reference equals cannot be overriden

Console.WriteLine($"1. Equals(1): {1.Equals(1)}");
Console.WriteLine($"1. Equals(2): {1.Equals(2)}");
Console.WriteLine($"1. Equals(null): {1.Equals(null)}");

Console.WriteLine($"\"ABC\".Equals(\"abc\"): {"abc".Equals("abc")}");

Console.WriteLine();

var johnny = new Person(1, "John");
var sameAsJohnny = new Person(1, "John");
var marie = new Person(1, "Marie");

Console.WriteLine($"johnny.Equals(sameAsJohnny): {johnny.Equals(sameAsJohnny)}");
Console.WriteLine($"johnny.Equals(marie): {johnny.Equals(marie)}");
Console.WriteLine($"johnny.Equals(null): {johnny.Equals(null)}");

var point1 = new Point(2, 4);

//var point1 = new Point(1, 5);
var point2 = new Point(1, 5);

var added = point1.Add(point2); // will work but awkward?
var added2 = point1 + point2;
Console.WriteLine($"Add points with point.Add: {added}");
Console.WriteLine($"Add points with point1 + point2: {added2}");

Console.WriteLine($"point1.Equals(point2): {point1.Equals(point2)}"); // point is point1 struct and hence value type, so equals method compares values
Console.WriteLine($"point1 == point2: {point1 == point2}");

//Console.WriteLine($"Point1 and point2 are equal: {point1 == point2}"); // == does not work for value types

Console.WriteLine($"1 == 1: {1 == 1}"); // because == is overloaded so it can take integers

int tenAsInt = 10;
decimal tenAsDecimal = tenAsInt; // implicit conversion

decimal someDecimal = 20.01m;
int someInt = (int)someDecimal; // explicit conversion - not allowed until explicitly stated that converts to (int) as conversion is not loseless

var tuple = Tuple.Create(10, 20);
Point tupleToPoint = tuple;

var timeOne = new Time(10, 30);
var timeTwo = new Time(15, 32);

Console.WriteLine($"count time: {timeOne + timeTwo}");

var fishyStruct1 = new FishyStruct
{
    Numbers = new List<int> { 1, 2, 3 }
};
var fishyStruct2 = fishyStruct1;

fishyStruct2.Numbers.Clear(); // everything will be deleted from both structs because List<int> Numbers is point1 reference type

// hash functionality
var hash1 = 123.GetHashCode();
var hash2 = "abc".GetHashCode();

Console.WriteLine($"{hash1}");
Console.WriteLine($"{hash2}");

var dictionary = new Dictionary<Point, string>();
dictionary[new Point(10, 20)] = "abc";

// GetHashCode default implementation
var dictionary2 = new Dictionary<Person, int>();
var martin = new Person(6, "Martin");
dictionary2[martin] = 5;
var theSameAsMartin = new Person(6, "Martin");
Console.WriteLine(dictionary2[martin]);

//Console.WriteLine(dictionary2[theSameAsMartin]);
Console.WriteLine(martin.GetHashCode());
Console.WriteLine(theSameAsMartin.GetHashCode());

var dictionary3 = new Dictionary<Point, int>();
var point11 = new Point(27, 1);
dictionary3[point11] = 99;
var point12 = new Point(27, 1);
Console.WriteLine(dictionary3[point12]);

Console.WriteLine(point11.GetHashCode());
Console.WriteLine(point12.GetHashCode());

var point21 = new Point(27, 1);
var point22 = new Point(27, 1);
var point23 = new Point(6, -1);

Console.WriteLine(point21.GetHashCode());
Console.WriteLine(point22.GetHashCode());
Console.WriteLine(point23.GetHashCode());

Console.WriteLine();

var person1 = new Person(6, "Martin");
var person2 = new Person(6, "Martin");
var person3 = new Person(7, "Bella");

Console.WriteLine(person1.GetHashCode());
Console.WriteLine(person2.GetHashCode());
Console.WriteLine(person3.GetHashCode());

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

readonly struct Point : IEquatable<Point>
{
    public int X { get; init; }
    public int Y { get; init; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Point() // only from C# 10 - constructor with zero parameters
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

    public override bool Equals(object? obj) // auto generated by VS
    {
        return obj is Point point && Equals(point);
    }

    public bool Equals(Point other) // If point is passed as parameter, C# uses the most concrete Equals method, this one
    {
        return X == other.X && Y == other.Y;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }

    public Point Add(Point point2) => new Point(X + point2.X, Y + point2.Y);

    public static Point operator +(Point a, Point b) => new Point(a.X + b.X, a.Y + b.Y);

    public static bool operator ==(Point point1, Point point2) => point1.Equals(point2);

    public static bool operator !=(Point point1, Point point2) => !point1.Equals(point2);

    public static implicit operator Point(Tuple<int, int> tuple)
    {
        return new Point(tuple.Item1, tuple.Item2);
    }
}

class Person
{
    public int Id { get; init; }
    public string Name { get; init; }

    public Person(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public Person()
    {
        //
    }

    public override bool Equals(object? obj)
    {
        return obj is Person other && Id == other.Id; // Id should come from business requiremenets, like how can 2 people be compared
    }

    public override int GetHashCode()
    {
        return Id;
    }
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

// Second exercise Structs

public struct Time2
{
    public int Hour { get; }
    public int Minute { get; }

    public Time2(int hour, int minute)
    {
        if (hour < 0 || hour > 23)
        {
            throw new ArgumentOutOfRangeException("Hour is out of range.");
        }

        if (minute < 0 || minute > 59)
        {
            throw new ArgumentOutOfRangeException("Minute is out of range.");
        }

        Hour = hour;
        Minute = minute;
    }

    public override string? ToString()
    {
        return $"{Hour.ToString("00")}:{Minute.ToString("00")}";
    }
}

// Third exercise Override Equals

public class FullName
{
    public string First { get; init; }
    public string Last { get; init; }

    public override string ToString() => $"{First} {Last}";

    public override bool Equals(object? obj)
    {
        return obj is FullName name && First == name.First && Last == name.Last;
    }
}

// Fourth exercise Operators override - Time structs
// Fifth exercise GetHashCode override
public struct Time
{
    public int Hour { get; }
    public int Minute { get; }

    public Time(int hour, int minute)
    {
        if (hour < 0 || hour > 23)
        {
            throw new ArgumentOutOfRangeException("Hour is out of range of 0-23");
        }
        if (minute < 0 || minute > 59)
        {
            throw new ArgumentOutOfRangeException("Minute is out of range of 0-59");
        }
        Hour = hour;
        Minute = minute;
    }

    public override string ToString() => $"{Hour.ToString("00")}:{Minute.ToString("00")}";

    public static bool operator ==(Time left, Time right) => left.Equals(right);

    public static bool operator !=(Time left, Time right) => !left.Equals(right);

    public static Time operator +(Time left, Time right)
    {
        int minTotal = left.Minute + right.Minute;
        int hourTotal = left.Hour + right.Hour;
        if (minTotal > 59)
        {
            hourTotal += 1;
            minTotal -= 60;
        }
        return new Time(hourTotal % 24, minTotal);
    }

    public override bool Equals([NotNullWhen(true)] object? obj)
    {
        return base.Equals(obj);
    }
}
