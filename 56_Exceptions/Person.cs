namespace _56_Exceptions;

public class Person
{
    public string Name { get; }

    public int YearOfBirth { get; }

    public Person(string name, int yearOfBirth)
    {
        if (name == string.Empty)
        {
            throw new Exception("Invalid name.");
        }
        if (yearOfBirth < 1900 || yearOfBirth > DateTime.Now.Year)
        {
            throw new Exception("Invalid year of birth.");
        }

        Name = name;
        YearOfBirth = yearOfBirth;
    }
}
