class InputValidator
{
    public bool InputValidation(string guess)
    {
        return int.TryParse(guess, out _);
    }
}
