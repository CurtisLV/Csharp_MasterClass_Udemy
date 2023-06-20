using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_DiceRoll;

public class GameManagerX
{
    private Random random;
    private int numberToGuess;
    private int maxTries;
    private int numberOfTries;

    public GameManagerX()
    {
        random = new Random();
        numberToGuess = random.Next(1, 7);
        maxTries = 3;
        numberOfTries = 0;
    }

    public void StartGame()
    {
        Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");
        while (numberOfTries < maxTries)
        {
            Console.WriteLine("Enter a number:");
            string guess = Console.ReadLine();

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
    }
}
