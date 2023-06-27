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
        public virtual int NumberOfLegs { get; } = 4;

        public virtual void MakeSound() =>
            Console.WriteLine("Make a generic animal sound !!!!!!!!!!");
    }

    class HousePet : Animal
    {
        public override void MakeSound() =>
            Console.WriteLine("<noises of happines when human comes home>");
    }

    public class Lion : Animal
    {
        //
    }

    public class Tiger : Animal
    {
        //
    }

    public class Duck : Animal
    {
        public override int NumberOfLegs => 2;
    }

    public class Spider : Animal
    {
        public override int NumberOfLegs => 8;
    }
}
