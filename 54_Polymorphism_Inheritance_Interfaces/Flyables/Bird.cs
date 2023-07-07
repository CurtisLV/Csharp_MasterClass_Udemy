namespace _54_Polymorphism_Inheritance_Interfaces.Flyables;

public interface IFlyable
{
    void Fly();
}

public class Bird
{
    public void Tweet() => Console.WriteLine("Tweet, tweet!");

    public void Fly() => Console.WriteLine("Flying using its wings.");
}

public class Kite
{
    public void Fly() => Console.WriteLine("Flying carried by the wind.");
}

public class Plane
{
    public void Fly() => Console.WriteLine("Flying using jet propulsion.");

    public void Fuel() => Console.WriteLine("Filling tanks with jet fuel.");
}
