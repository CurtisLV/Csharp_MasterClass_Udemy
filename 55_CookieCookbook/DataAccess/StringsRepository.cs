namespace _55_CookieCookbook.DataAccess
{
    public abstract class StringsRepository : IStringsRepository
    {
        public List<string> Read(string filePath)
        {
            // check if file exists
            if (File.Exists(filePath))
            {
                var fileContents = File.ReadAllText(filePath);
                return TextToStrings(fileContents);
            }
            // else return empty List<string>
            return new List<string>();
        }

        // helps read file content
        protected abstract List<string> TextToStrings(string fileContents);

        public void Write(string filePath, List<string> strings)
        {
            StreamWriter writer = null;
            // check if file exists
            if (!File.Exists(filePath))
            {
                writer = File.CreateText(filePath);
            }

            using (writer = File.AppendText(filePath))
            {
                foreach (string str in strings)
                {
                    writer.WriteLine(str);
                }
            }
        }

        // helps write to file
        protected abstract string StringsToText(List<string> strings);
    }
}
