﻿namespace _55_CookieCookbook.DataAccess
{
    public abstract class StringsRepository : IStringsRepository
    {
        public List<string> Read(string filePath)
        {
            // check if file exists

            // else return empty List<string>
        }

        // helps read file content
        protected abstract List<string> TextToStrings(string fileContents);

        public void Write(string fileContents)
        {
            //
        }

        // helps write to file
        protected abstract string StringsToText(List<string> strings);
    }
}
