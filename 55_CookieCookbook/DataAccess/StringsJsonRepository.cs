using System.Text;

namespace _55_CookieCookbook.DataAccess;

class StringsJsonRepository : StringsRepository
{
    // for Read
    protected override List<string> TextToStrings(string fileContents)
    {
        // return List<string> where each string is Json object
        string[] result = fileContents.Split(Environment.NewLine);
        return result.ToList();
    }

    // for Write
    protected override string StringsToText(List<string> strings)
    {
        // return one string
        // where each of the strings is separated by newline
        StringBuilder sb = new StringBuilder();
        foreach (string s in strings)
        {
            sb.Append(s + Environment.NewLine);
        }

        return sb.ToString().TrimEnd();
    }
}
