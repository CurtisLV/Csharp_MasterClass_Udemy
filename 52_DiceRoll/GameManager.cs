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

    public void StartGame {
        //
    }
}
