namespace _54_Polymorphism_Inheritance_Interfaces.Extensions;

public class StringsProcessor
{
    public virtual List<string> Process(List<string> result)
    {
        return new List<string>(result);
    }
}
