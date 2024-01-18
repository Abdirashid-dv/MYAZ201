using Microsoft.AspNetCore.Mvc;
using Models;
using Question1.Repositories;
using Repositories.Contracts;

namespace Controllers;

[ApiController]
[Route("api/projects")]
public class ProjectsController : ControllerBase
{
    private readonly IProjectRepository _projectRepository;

    public ProjectsController(IProjectRepository projectRepository)
    {
        _projectRepository = projectRepository;
    }


    // Tüm projelerin listesini döner.
    [HttpGet("/{id:int}")]
    public IActionResult GetOneProject([FromRoute(Name = "id")] int id)
    {
        return Ok(_projectRepository.GetOneProject(id));
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateOneProject([FromRoute(Name = "id")] int id,
        [FromBody] Project project)
    {
        _projectRepository.UpdateOneProject(id, project);
        return Ok(project);
    }
}