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

var numbers = new[] { 5, 9, 2, 12, 6 };
bool isAnyLargerThan10 = numbers.Any(num => num > 10);

foreach (var animal in animalsWithD)
{
    Console.WriteLine(animal);
}

var isAnyPetNamedBruce = Data.Pets.Any(pet => pet.Name == "Bruce");
Printer.Print(isAnyPetNamedBruce, nameof(isAnyPetNamedBruce));

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
