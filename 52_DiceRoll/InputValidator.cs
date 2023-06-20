


class InputValidator
{
    bool InputValidation(string guess)
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
