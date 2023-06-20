using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_DiceRoll;

internal class GameManagerX
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
}
