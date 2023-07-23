namespace _55_CookieCookbook.DataAccess;

public interface IStringsRepository
{
    public List<string> Read(string filePath);

    public void Write(string filePath, List<string> strings);
}
