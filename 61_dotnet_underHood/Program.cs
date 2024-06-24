﻿int number = 5;
var john = new Person { Name = "John", Age = 35 };

AddOneToValue(ref number);
AddOneToPerson(john);

Console.WriteLine("This is number " + number);
Console.WriteLine("This is person " + john.Age);

int otherNumber = 15;

MethodWithOutParameter(out otherNumber);
Console.WriteLine("Other number is " + otherNumber);

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
