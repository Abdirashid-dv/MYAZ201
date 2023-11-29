using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories;

public class RepositoryContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }

    public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Employee>().HasData(
            new Employee() { EmployeeId = 1, FirstName = "Abdirashid", LastName = "Mowlid", Salary = 5_500 },
            new Employee() { EmployeeId = 2, FirstName = "Arlinda", LastName = "Uruci", Salary = 5_000 },
            new Employee() { EmployeeId = 3, FirstName = "Abduvahap", LastName = "Oumarou", Salary = 4500 }
        );
    }
}