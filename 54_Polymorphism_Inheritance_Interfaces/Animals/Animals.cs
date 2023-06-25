using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_Polymorphism_Inheritance_Interfaces.Animals
{
    public class Exercise
    {
        public List<int> GetCountsOfAnimalsLegs()
        {
            var animals = new List<Animal> { new Lion(), new Tiger(), new Duck(), new Spider() };

            var result = new List<int>();
            foreach (var animal in animals)
            {
                result.Add(animal.NumberOfLegs);
            }
            return result;
        }
    }

    public class Animal
    {
        //
    }

    public class Lion
    {
        //
    }

    public class Tiger
    {
        //
    }

    public class Duck
    {
        //
    }

    public class Spider
    {
        //
    }
}
