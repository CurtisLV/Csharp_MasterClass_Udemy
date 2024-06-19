int number = 5;
var john = new Person { Name = "John", Age = 35 };

AddOneToValue(number);
AddOneToPerson(john);

Console.WriteLine("This is number " + number);
Console.WriteLine("This is person " + john.Age);

void AddOneToValue(int number)
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
