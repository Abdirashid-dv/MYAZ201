using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace Controllers;

[ApiController]
[Route("api/projects")]
public class ProjectsController : ControllerBase
{
    public ProjectRepository _projectRepository;
    public ProjectsController()
    {
        _projectRepository = new ProjectRepository();
    }

    // Tüm projelerin listesini döner.
    [HttpGet("/")]
    public IActionResult GetAllProjects()
    {
        return Ok(_projectRepository.Projects);
    }


    [HttpGet("less-than-budget/{budget}")]

    public IActionResult GetFilteredProject(decimal budget)
    {
        if (budget <= 0)
        {
            return BadRequest("Bütçe değeri 0'dan küçük olamaz.");
        }

        var filteredProjects = _projectRepository.Projects.Where(p => p.Budget < budget);

        return Ok(filteredProjects);
    }


}




