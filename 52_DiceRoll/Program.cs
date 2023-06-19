var random = new Random();
int numberToGuess = random.Next(1, 7);
int maxTries = 3;
int numberOfTries = 0;

Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");

do
{
    Console.WriteLine("Enter a number:");
    var guess = Console.ReadLine();

    if (InputValidation(guess))
    {
        if (numberToGuess == int.Parse(guess))
        {
            break;
        }
        else
        {
            Console.WriteLine("Wrong number!");
            numberOfTries++;
        }
    }
    else
    {
        Console.WriteLine("Incorrect input!");
    }
} while (numberOfTries < maxTries);

// after guessing, determin result
if (numberOfTries < maxTries)
{
    Console.WriteLine($"You win!");
}
else
{
    Console.WriteLine($"You lose!");
}

bool InputValidation(string? guess)
{
    try
    {
        int.Parse(guess);
    }
    catch
    {
        return false;
    }

    return true;
}

Console.WriteLine($"The number was {numberToGuess}");
Console.ReadKey();
