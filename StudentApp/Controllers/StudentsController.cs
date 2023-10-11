using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using StudentApp.Models;

namespace StudentApp.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        public Student[] StudentList { get; set; }

        public StudentsController()
        {
            StudentList = new Student[4];

            StudentList[0] = new Student
            {
                Number = 112,
                FirstName = "Hafza",
                LastName = "Çataklı"
            };

            StudentList[1] = new Student
            {
                Number = 118,
                FirstName = "Gulbin",
                LastName = "Beydilli"
            };

            StudentList[2] = new Student
            {
                Number = 120,
                FirstName = "Berat",
                LastName = "Gungor"
            };

            StudentList[3] = new Student
            {
                Number = 910,
                FirstName = "Celal",
                LastName = "Helilov"
            };
        }

        [HttpGet] // localhost/api/students
        public Student[] GetAllStudents()
        {
            return StudentList;
        }

        [HttpGet("{id}")] // localhost/api/students/{id}
        public Student GetOneStudent(int id)
        {
            if (id <= 3)
            {
                return StudentList[id];
            }
            else
            {
                throw new IndexOutOfRangeException($"Ogrenci Bulamadi simdilik {StudentList.Length} var.");
            }
        }
    }
}