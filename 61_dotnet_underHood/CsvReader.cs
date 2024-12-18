using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_dotnet_underHood;

public class CsvReader
{
    public CsvData Read(string path)
    {
        using var streamReader = new StreamReader(path);

        const string Separator = ",";
        var columns = streamReader.ReadLine().Split(Separator);
    }
}

public class CsvData
{
    public string[] Columns { get; }
    public IEnumerable<string[]> Rows { get; }

    public CsvData(string[] columns, IEnumerable<string[]> rows)
    {
        Columns = columns;
        Rows = rows;
    }
}
