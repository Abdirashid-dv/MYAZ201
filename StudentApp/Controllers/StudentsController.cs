using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using StudentApp.Models;

namespace StudentApp.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        private readonly ILogger<StudentsController> _logger;
        private readonly StudentRepository _studentRepository;

        public StudentsController(ILogger<StudentsController> logger, StudentRepository studentRepository)
        {
            _logger = logger;
            this._studentRepository = studentRepository;
        }

        [HttpGet] // localhost/api/students
        public IActionResult GetAllStudents()
        {
            _logger.LogInformation($"GetAllStudents has been called.");
            return Ok(_studentRepository.GetAllStudents());
        }

        [HttpGet("{id}")] // localhost/api/students/{id}
        public IActionResult GetOneStudent(int id)
        {
            _logger.LogInformation($"GetOneStudent with the id: {id} has beeen called.");
            var result = _studentRepository.GetOneStudent(id);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpPost]

        public IActionResult CreateOneStudent(Student student)
        {
            _logger.LogInformation($"CreateOneStudent has been called.");
            var result = _studentRepository.CreateOneStudent(student);
            return result == null ? BadRequest("This student already created!") : Ok(result);
        }

        [HttpPut("{id:int}")]

        public IActionResult UpdateOneStudent([FromRoute] int id, [FromBody] Student student)
        {
            _logger.LogInformation($"UpdateOneStudent with id : {id} has been called.");
            var result = _studentRepository.UpdateOneStudent(id, student);
            return result == 0 ? NotFound("Student not found!") : Ok(GetOneStudent(student.Number));
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteOneStudent(int id)
        {
            _logger.LogInformation($"DeleteOneStudent with the id: {id} has been called.");
            var result = _studentRepository.DeleteOneStudent(id);
            return result == 0 ? NotFound("This student not found!") : Ok("Student Information deleted!");


        }
    }
}