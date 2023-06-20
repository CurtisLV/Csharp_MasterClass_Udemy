class GameManager
{
    private Random random;
    private int numberToGuess;
    private int maxTries;
    private int numberOfTries;

    public GameManager()
    {
        random = new Random();
        numberToGuess = random.Next(1, 7);
        maxTries = 3;
        numberOfTries = 0;
    }

    public void StartGame
    {
        Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");

while (numberOfTries<maxTries)
{
    Console.WriteLine("Enter a number:");
    var guess = Console.ReadLine();

    if (inputValidator.InputValidation(guess))
    {
        if (numberToGuess == int.Parse(guess))
        {
            Console.WriteLine($"You win!");
            return;
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
}
;

Console.WriteLine($"You lose!");
Console.WriteLine($"The number was {numberToGuess}");
Console.ReadKey();

    }
}
