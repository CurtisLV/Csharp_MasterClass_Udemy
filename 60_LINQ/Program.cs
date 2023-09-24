static bool IsAnyWordUpperCase(IEnumerable<string> words)
{
    foreach (var word in words)
    {
        if (word.ToUpper() == word)
        {
            return true;
        }
    }
    return false;
}
