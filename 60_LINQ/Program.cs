var wordsNoUppercase = new string[] { "apple", "banana", "cherry", "date", "elderberry" };
Console.WriteLine(IsAnyWordUpperCase(wordsNoUppercase));
var wordsSomeAllUppercase = new string[] { "Grapes", "kiWi", "Lychee", "ManGo", "ORANGE" };
Console.WriteLine(IsAnyWordUpperCase(wordsSomeAllUppercase));

var wordsLetters = new List<string> { "a", "bb", "ccc", "dddd" };
var wordsLongerThan2Letters = wordsLetters.Where(w => w.Length > 2);

var numbersArray = new int[] { 1, 2, 5, 8, 9, 12, 77, 1, 2 };
var oddNumbers = numbersArray.Where(num => num % 2 == 1);

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
