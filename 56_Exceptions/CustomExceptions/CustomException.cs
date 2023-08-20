namespace _56_Exceptions.CustomExceptions;

[Serializable]
public class CustomException : Exception
{
    public int StatusCode { get; }

    public CustomException()
    {
        //
    }
    public CustomException(string message, int statusCode) : base(message)
    {
        StatusCode = statusCode;
    }

    public CustomException(string message, Exception innerException, int statusCode) : base(message, innerException)
    {
        StatusCode=statusCode;
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
