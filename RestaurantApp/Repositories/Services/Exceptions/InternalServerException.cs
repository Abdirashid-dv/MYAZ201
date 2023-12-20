namespace Repositories.Services.Exceptions
{

    public sealed class InternalServerException : Exception
    {

        public InternalServerException(string message = "Internal server error!")
        : base(message)
        {

        }

    }

}