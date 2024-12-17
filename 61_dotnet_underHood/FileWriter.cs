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
        _streamWriter?.Flush();
    }
}

public class SpecificLineFromTextFileReader
{
    private readonly StreamReader _streamReader;

    public SpecificLineFromTextFileReader(string filepath)
    {
        _streamReader = new StreamReader(filepath);
    }

    public string ReadLineNumber(int lineNumber)
    {
        for (int i = 0; i < lineNumber - 1; i++)
        {
            _streamReader.ReadLine();
        }

        return _streamReader.ReadLine();
    }
}
