using EmployeeShiftSystem.Models;
using Microsoft.EntityFrameworkCore;


namespace EmployeeShiftSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
    }
}
