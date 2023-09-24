var wordsNoUppercase = new string[] { "apple", "banana", "cherry", "date", "elderberry" };
Console.WriteLine(IsAnyWordUpperCase(wordsNoUppercase));
var wordsSomeAllUppercase = new string[] { "Grapes", "kiWi", "Lychee", "ManGo", "ORANGE" };
Console.WriteLine(IsAnyWordUpperCase(wordsSomeAllUppercase));

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
static bool IsAnyWordUpperCase_Linq(IEnumerable<string> words)
{
    return words.Any(word => word.ToUpper() == word);
}
