static class InputValidator
{
    public static bool IsValidNumber(string guess)
    {
        return int.TryParse(guess, out _);
    }
}
