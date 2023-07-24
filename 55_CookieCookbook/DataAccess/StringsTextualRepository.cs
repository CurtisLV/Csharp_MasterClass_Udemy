namespace _55_CookieCookbook.DataAccess;

class StringsTextualRepository : StringsRepository
{
    private static readonly string Separator = Environment.NewLine;

    // for Read
    protected override List<string> TextToStrings(string fileContents)
    {
        // create a list of strings
        // where each string is a line in text document (like 0, 1, 4)
    }

    // for Write
    protected override string StringsToText(List<string> strings)
    {
        // for each string, write it to a new line in text document
    }
}
