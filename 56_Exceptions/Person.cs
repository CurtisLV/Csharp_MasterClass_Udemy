﻿namespace _56_Exceptions;

public class Person
{
    public string Name { get; }

    public int YearOfBirth { get; }

    public Person(string name, int yearOfBirth)
    {
        if (name is null)
        {
            throw new ArgumentException("The name cannot be null.");
        }
        if (name == string.Empty)
        {
            throw new ArgumentException("The name cannot be empty.");
        }
        if (yearOfBirth < 1900 || yearOfBirth > DateTime.Now.Year)
        {
            throw new ArgumentOutOfRangeException(
                "The year of birth must be between 1900 and current year"
            );
        }

        Name = name;
        YearOfBirth = yearOfBirth;
    }
}
