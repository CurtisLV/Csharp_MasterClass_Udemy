namespace _2_NamesBeforeRefactorToSRP;

class NamesFormatter
{
    public string Format(List<string> names)
    {
        return string.Join(Environment.NewLine, names);
    }
}
