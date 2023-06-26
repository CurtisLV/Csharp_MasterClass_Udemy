namespace _54_Polymorphism_Inheritance_Interfaces.Extensions;

public class StringsTrimmingProcessor : StringsProcessor
{
    public override List<string> Process(List<string> result)
    {
        List<string> words = new List<string>();
        foreach (var word in result)
        {
            words.Add(word.Substring(0, (word.Length / 2)));
        }
        return result;
    }
}
