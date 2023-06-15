var names2 = new Names2();
var path = names2.BuildFilePath();

if (File.Exists(path))
{
    Console.WriteLine("Names file already exists. Loading names.");
    names2.ReadFromTextFile();
}
else
{
    Console.WriteLine("Names file does not yet exist.");

    //let's imagine they are given by the user
    names2.AddName("John");
    names2.AddName("not a valid name");
    names2.AddName("Claire");
    names2.AddName("123 definitely not a valid name");

    Console.WriteLine("Saving names to the file.");
    names2.WriteToTextFile();
}
Console.WriteLine(names2.Format());

Console.ReadLine();

public class Names2
{
    private readonly List<string> _names = new List<string>();

    public void AddName(string name)
    {
        if (IsValidName(name))
        {
            _names.Add(name);
        }
    }

    private bool IsValidName(string name)
    {
        return name.Length >= 2
            && name.Length < 25
            && char.IsUpper(name[0])
            && name.All(char.IsLetter);
    }

    public void ReadFromTextFile()
    {
        var fileContents = File.ReadAllText(BuildFilePath());
        var namesFromFile = fileContents.Split(Environment.NewLine).ToList();
        foreach (var name in namesFromFile)
        {
            AddName(name);
        }
    }

    public void WriteToTextFile() => File.WriteAllText(BuildFilePath(), Format());

    public string BuildFilePath()
    {
        //we could imagine this is much more complicated
        //for example that path is provided by the user and validated
        return "names.txt";
    }

    public string Format() => string.Join(Environment.NewLine, _names);
}
