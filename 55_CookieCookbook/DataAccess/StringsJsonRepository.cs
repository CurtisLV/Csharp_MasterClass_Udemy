namespace _55_CookieCookbook.DataAccess;

class StringsJsonRepository : StringsRepository
{
    // for Read
    protected override List<string> TextToStrings(string fileContents)
    {
        // return List<string> where each string is Json object
    }

    // for Write
    protected override string StringsToText(List<string> strings)
    {
        // return one string
        // where each of the strings is separated by newline
    }
}
