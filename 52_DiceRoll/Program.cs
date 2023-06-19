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

bool InputValidation(string? guess)
{
    throw new NotImplementedException();
}

Console.ReadKey();
