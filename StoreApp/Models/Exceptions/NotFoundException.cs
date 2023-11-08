namespace StoreApp.Models.Exceptions;

public abstract class NotFoundException : Exception
{
    public NotFoundException(string message)
    : base(message)
    {

    }
}

public class ProductNotFoundException : NotFoundException
{
    public ProductNotFoundException(int id) : base($"Product with id: {id} not found!")
    {
    }
}