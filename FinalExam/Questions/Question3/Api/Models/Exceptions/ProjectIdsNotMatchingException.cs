namespace Models.Exceptions;


public class ProjectIdsNotMatchingException : IdsNotMatchingException
{
    public ProjectIdsNotMatchingException(int id, int bodyId) : base($"Project id {id} does not match body id {bodyId}")
    {
    }
}