using Microsoft.EntityFrameworkCore;
using ManagementPortal.Models;
using Microsoft.Identity.Client;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace ManagementPortal.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }

        public DbSet<Employee>
    }
}
