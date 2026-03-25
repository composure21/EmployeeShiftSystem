using Microsoft.AspNetCore.Mvc;

namespace EmployeeShiftSystem.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; } // Manager, Staff
        public string Email { get; set; }
    }
}
