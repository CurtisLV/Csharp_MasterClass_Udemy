namespace _54_Polymorphism_Inheritance_Interfaces.Extensions;

public static class StringExtensions
{
    public static int CountLines(this string input) => input.Split(Environment.NewLine).Length;
}
