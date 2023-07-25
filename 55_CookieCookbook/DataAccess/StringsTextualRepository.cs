namespace _55_CookieCookbook.DataAccess;

class StringsTextualRepository : StringsRepository
{
    private static readonly string Separator = Environment.NewLine;

    // for Read
    protected override List<string> TextToStrings(string fileContents)
    {
        // return List<string>
        // where each string is a line in text document (like 0,1,4)
        List<string> linesList = new List<string>(fileContents.Split(Environment.NewLine));
        return linesList;
    }

    // for Write
    protected override string StringsToText(List<string> strings)
    {
        // return one string
        // that is all lines separated by NewLine
        return string.Empty;
    }
}
