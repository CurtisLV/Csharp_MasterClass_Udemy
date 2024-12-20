Console.ReadKey();

public class Dog
{
    public string Name { get; } // length must be between 2 and 10 chars

    public Dog(string name) => Name = name;
}

public class Person
{
    public string Name { get; }
    public int YearOfBirth { get; }

    public Person(string name, int age)
    {
        Name = name;
        YearOfBirth = age;
    }

    public Person(string name) => Name = name;
}
