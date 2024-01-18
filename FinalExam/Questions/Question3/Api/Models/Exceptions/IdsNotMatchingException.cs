namespace Models.Exceptions;

public class IdsNotMatchingException : Exception
{

    public IdsNotMatchingException(string message) : base(message)
    {
    }
}