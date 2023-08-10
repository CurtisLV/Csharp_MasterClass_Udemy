using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_Exceptions
{
    public class Person
    {
        public string Name { get; }

        public int YearOfBirth { get; }

        public Person(string name, int yearOfBirth)
        {
            Name = name;
            YearOfBirth = yearOfBirth;
        }
    }
}
