var random = new Random();
int number = random.Next(1, 7);
int maxTries = 3;
int numberOfTries = 0;

Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");

do
{
    Console.WriteLine("Enter a number:");
    var guess = Console.ReadLine();

    if (InputValidation(guess))
    {
        //
    }
    else
    {
        //
    }
} while (numberOfTries <= maxTries);

// end of
if (numberOfTries < maxTries)
{
    Console.WriteLine($"You win!");
}
else
{
    Console.WriteLine($"You loose!");
}

bool InputValidation(string? guess)
{
    return true; // TODO add proper validation
}

Console.ReadKey();
