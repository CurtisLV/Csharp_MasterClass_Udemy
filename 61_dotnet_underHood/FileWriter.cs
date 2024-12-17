using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_dotnet_underHood;

public class FileWriter : IDisposable
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

    public void Dispose()
    {
        _streamWriter.Dispose();
    }
}

public class SpecificLineFromTextFileReader : IDisposable
{
    private readonly StreamReader _streamReader;

    public SpecificLineFromTextFileReader(string filepath)
    {
        _streamReader = new StreamReader(filepath);
    }

    public string ReadLineNumber(int lineNumber)
    {
        _streamReader.DiscardBufferedData();
        _streamReader.BaseStream.Seek(0, SeekOrigin.Begin);

        for (var i = 0; i < lineNumber - 1; ++i)
        {
            _streamReader.ReadLine();
        }

        return _streamReader.ReadLine();
    }

    public void Dispose()
    {
        _streamReader.Dispose();
    }
}
