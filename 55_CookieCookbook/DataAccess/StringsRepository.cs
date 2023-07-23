namespace _55_CookieCookbook.DataAccess
{
    public abstract class StringsRepository : IStringsRepository
    {
        public List<string> Read(string filePath)
        {
            // check if file exists

            // else return empty List<string>
        }

        public void Write(string fileContents)
        {
            //
        }

        protected abstract List<string> TextToStrings(string fileContents);

        protected abstract string StringsToText(List<string> strings);
    }
}
