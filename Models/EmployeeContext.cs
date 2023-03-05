using Microsoft.EntityFrameworkCore;

namespace _16_MVC_Uygulama2.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> option) : base(option) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
