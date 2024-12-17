using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_dotnet_underHood;

public class FileWriter
{
    private readonly StreamWriter _streamWriter;

    public FileWriter(string filepath)
    {
        _streamWriter = new StreamWriter(filepath, true);
    }

    public void Write(string text)
    {
        _streamWriter.WriteLine(text);
    }
}
