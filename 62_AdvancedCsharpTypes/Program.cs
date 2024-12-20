using System.ComponentModel.DataAnnotations;

var validPerson = new Person("John", 1989);
var invalidDog = new Dog("F");

var validator = new Validator();

Console.WriteLine(validator.Validate(validPerson) ? "Person is valid" : "Person is invalid");
Console.WriteLine(validator.Validate(invalidDog) ? "Dog is valid" : "Dog is invalid");

Console.ReadKey();

public class Dog
{
    [StringLengthValidate(2, 10)]
    public string Name { get; } // length must be between 2 and 10

    public Dog(string name) => Name = name;
}

public class Person
{
    [StringLengthValidate(2, 25)]
    public string Name { get; } // length must be between 2 and 25
    public int YearOfBirth { get; }

    public Person(string name, int age)
    {
        Name = name;
        YearOfBirth = age;
    }

    public Person(string name) => Name = name;
}
