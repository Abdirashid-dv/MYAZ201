using Models;

namespace Repositories.Contracts;

public interface IProjectRepository
{
    Project? GetOneProject(int id);
    Project? UpdateOneProject(int id, Project project);
}