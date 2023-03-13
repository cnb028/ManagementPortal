using Microsoft.EntityFrameworkCore;
using ManagementPortal.Models;
using Microsoft.Identity.Client;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace ManagementPortal.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }

        public DbSet<Employee> Employee { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Luke Skywalker",
                    StartDate = new DateTime(2010, 6 , 15),
                    Title = "Human Resources Manager",
                    PayRate = 30,
                    Hours = 40,
                },
                new Employee
                {
                    Id = 2,
                    Name = "Leia Organa",
                    StartDate = new DateTime(2007, 12, 17),
                    Title = "Junior Accountant",
                    PayRate = 30,
                    Hours = 40,
                },
                new Employee
                {
                    Id = 3,
                    Name = "Ezra Bridger",
                    StartDate = new DateTime(2007, 12, 17),
                    Title = "Junior Accountant",
                    PayRate = 30,
                    Hours = 40,
                }
            );
        }
    }
}
