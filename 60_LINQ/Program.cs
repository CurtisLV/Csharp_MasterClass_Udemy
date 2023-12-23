using _60_LINQ;
using _60_LINQ.SampleData;
using _60_LINQ.Utilities;

var wordsNoUppercase = new string[] { "apple", "banana", "cherry", "date", "elderberry" };
Console.WriteLine(IsAnyWordUpperCase(wordsNoUppercase));
var wordsSomeAllUppercase = new string[] { "Grapes", "kiWi", "Lychee", "ManGo", "ORANGE" };
Console.WriteLine(IsAnyWordUpperCase(wordsSomeAllUppercase));

var wordsLetters = new List<string> { "a", "bb", "ccc", "dddd" };
var wordsLongerThan2Letters = wordsLetters.Where(w => w.Length > 2);

var numbersArray = new int[] { 1, 2, 5, 8, 9, 12, 77, 1, 2 };
var oddNumbers = numbersArray.Where(num => num % 2 == 1);

var numsAppend = new List<int> { 5, 7, 8, 1, 9, 1 };
var numsWith10 = numsAppend.Append(10);

Console.WriteLine("Numbers: " + string.Join(", ", numsAppend));
Console.WriteLine("Numbers: " + string.Join(", ", numsWith10));

var oddNumsOrdered = numsWith10.Where(num => num % 2 == 1).OrderBy(num => num);
Console.WriteLine("Numbers: " + string.Join(", ", oddNumsOrdered));

var animals = new List<string> { "Dolphin", "Duck", "Lion", "Tiger" };
var animalsWithD = animals.Where(animal =>
{
    Console.WriteLine("Checking animal: " + animal);
    return animal.StartsWith('D');
});

foreach (var animal in animalsWithD)
{
    Console.WriteLine(animal);
}

//Console.WriteLine(" - Any: ");
//Any.Run();
//Console.WriteLine(" - All: ");
//All.Run();
//Console.WriteLine(" - Count: ");
//Count.Run();
//Console.WriteLine(" - Contains: ");
//Contains.Run();
//Console.WriteLine(" - Order by: ");
//OrderBy.Run();

//Console.WriteLine();
//Console.WriteLine(" - First/Last: ");
//FirstLast.Run();

//Console.WriteLine();
//Console.WriteLine(" - Where: ");
//Where.Run();

//Console.WriteLine();
//Console.WriteLine(" - Distinct: ");
//Distinct.Run();

//Console.WriteLine();
//Console.WriteLine(" - Select: ");
//Select.Run();

Console.WriteLine();
Console.WriteLine(" - Average: ");
Average.Run();

Console.ReadKey();

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

// first coding exercise

static bool IsAnyWordWhiteSpace(List<string> words)
{
    return words.Any(word => word.All(letter => char.IsWhiteSpace(letter)));
}

// Second coding exercise

static int CountListsContainingZeroLongerThan(int length, List<List<int>> listsOfNumbers)
{
    return listsOfNumbers.Count(list => list.Count() > length && list.Contains(0));
}

// third coding exercise

static string FindShortestWord(List<string> words)
{
    return words.OrderBy(w => w.Length).First();
}

// fourth coding exercise

static IEnumerable<DateTime> GetFridaysOfYear(int year, IEnumerable<DateTime> dates)
{
    return dates.Where(date => date.Year == year && date.DayOfWeek == DayOfWeek.Friday).Distinct();
}

// fifth coding exercise
static double CalculateAverageDurationInMilliseconds(IEnumerable<TimeSpan> timeSpans)
{
    //your code goes here
}
