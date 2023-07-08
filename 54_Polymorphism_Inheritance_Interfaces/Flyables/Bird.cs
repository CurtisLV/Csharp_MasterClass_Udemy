namespace _54_Polymorphism_Inheritance_Interfaces.Flyables;

public interface IFlyable
{
    void Fly();
}

public class Bird : IFlyable
{
    public void Tweet() => Console.WriteLine("Tweet, tweet!");

    public void Fly() => Console.WriteLine("Flying using its wings.");
}

public class Kite : IFlyable
{
    public void Fly() => Console.WriteLine("Flying carried by the wind.");
}

public class Plane : IFlyable
{
    public void Fly() => Console.WriteLine("Flying using jet propulsion.");

    public void Fuel() => Console.WriteLine("Filling tanks with jet fuel.");
}
