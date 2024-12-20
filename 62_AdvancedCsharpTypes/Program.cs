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
