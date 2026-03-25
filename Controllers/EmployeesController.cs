using EmployeeShiftSystem.Models;
using Microsoft.AspNetCore.Mvc;
using EmployeeShiftSystem.Data;

namespace EmployeeShiftSystem.Controllers
{
    [ApiController]
    [Route("api/employees")]
    public class EmployeesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EmployeesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return Ok(employee);
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(_context.Employees.ToList());
        }
    }
}
