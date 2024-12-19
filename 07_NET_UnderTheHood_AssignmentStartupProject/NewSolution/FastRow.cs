namespace CsvDataAccess.NewSolution;

public class FastRow
{
    private Dictionary<string, int> _intsData;
    private Dictionary<string, bool> _boolsData;
    private Dictionary<string, decimal> _decimalsData;
    private Dictionary<string, string> _stringsData;

    public void AssignCell(string columnName, bool value)
    {
        _boolsData[columnName] = value;
    }

    public void AssignCell(string columnName, int value)
    {
        _intsData[columnName] = value;
    }

    public void AssignCell(string columnName, decimal value)
    {
        _decimalsData[columnName] = value;
    }

    public void AssignCell(string columnName, string value)
    {
        _stringsData[columnName] = value;
    }

    public object GetAtColumn(string columnName)
    {
        if (_boolsData.ContainsKey(columnName))
        {
            return _boolsData[columnName];
        }
        if (_stringsData.ContainsKey(columnName))
        {
            return _stringsData[columnName];
        }
        if (_intsData.ContainsKey(columnName))
        {
            return _intsData[columnName];
        }
        if (_decimalsData.ContainsKey(columnName))
        {
            return _decimalsData[columnName];
        }
        return null;
    }
}
