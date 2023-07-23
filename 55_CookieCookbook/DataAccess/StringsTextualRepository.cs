namespace _55_CookieCookbook.DataAccess;

class StringsTextualRepository : StringsRepository
{
    private static readonly string Separator = Environment.NewLine;

    protected override string StringsToText(List<string> strings)
    {
        throw new NotImplementedException();
    }

    protected override List<string> TextToStrings(string fileContents)
    {
        throw new NotImplementedException();
    }
}
