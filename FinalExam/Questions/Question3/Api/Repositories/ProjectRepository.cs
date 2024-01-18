using Microsoft.EntityFrameworkCore;
using Models;
using Models.Exceptions;
using Repositories;
using Repositories.Contracts;

namespace Question1.Repositories;

public class ProjectRepository : IProjectRepository
{
    private readonly RepositoryContext _context;

    public ProjectRepository(RepositoryContext context)
    {
        _context = context;
    }

    public Project? GetOneProject(int id)
    {
        return _context
            .Projects
            .AsNoTracking()
            .SingleOrDefault(p => p.ProjectId.Equals(id));
    }

    public Project? UpdateOneProject(int id, Project project)
    {
        if (!id.Equals(project.ProjectId))
        {
            throw new ProjectIdsNotMatchingException(id, project.ProjectId);
        }
        var existingProject = _context
            .Projects
            .SingleOrDefault(p => p.ProjectId.Equals(id));



        existingProject.ProjectName = project.ProjectName;
        existingProject.Description = project.Description;
        existingProject.StartDate = project.StartDate;
        existingProject.EndDate = project.EndDate;
        existingProject.Budget = project.Budget;

        _context.SaveChanges();

        return existingProject;
    }
}