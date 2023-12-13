using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace EmployeeApi.Controllers;

[ApiController]
[Route("api/employees")]

public class EmployeesController : ControllerBase
{
    private readonly RepositoryContext _context;

    public EmployeesController(RepositoryContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAllEmployees()
    {
        // throw new Exception();
        var employees = _context.Employees.ToList();
        return Ok(employees);
    }
    [HttpPost]
    public IActionResult CreateOneEmployee(Employee employee)
    {
        _context.Employees.Add(employee);
        _context.SaveChanges();

        return NoContent();
    }

    [HttpPut]
    public IActionResult UpdateOneEmployee(int id, Employee employee)
    {
        var emp = _context.Employees.SingleOrDefault(e => e.EmployeeId.Equals(id));
        if (emp is not null)
        {
            emp.FirstName = employee.FirstName;
            emp.LastName = employee.LastName;
            emp.Salary = employee.Salary;

            _context.SaveChanges();

        }

        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteOneEmployee(int id)
    {
        var employee = _context.Employees.SingleOrDefault(e => e.EmployeeId.Equals(id));
        if (employee is not null)
        {
            _context.Remove(employee);

            _context.SaveChanges();
        }

        return NoContent();

    }

}