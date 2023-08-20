namespace _56_Exceptions.CustomExceptions;

public class CustomException : Exception
{
    public int StatusCode { get; }

    public CustomException()
    {
        //
    }

    public CustomException(string message) : base(message)
    {
        //
    }

    public CustomException(string message, Exception innerException) : base(message, innerException)
    {
        //
    }
}
