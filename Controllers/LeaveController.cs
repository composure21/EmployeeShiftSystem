using EmployeeShiftSystem.Models;
using Microsoft.AspNetCore.Mvc;
using EmployeeShiftSystem.Data;

namespace EmployeeShiftSystem.Controllers
{
    [ApiController]
    [Route("api/leave")]
    public class LeaveController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LeaveController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> RequestLeave(LeaveRequest request)
        {
            _context.LeaveRequests.Add(request);
            await _context.SaveChangesAsync();
            return Ok(request);
        }

        [HttpPut("{id}/approve")]
        public async Task<IActionResult> ApproveLeave(int id)
        {
            var leave = await _context.LeaveRequests.FindAsync(id);
            leave.Status = "Approved";
            await _context.SaveChangesAsync();
            return Ok(leave);
        }
    }
}
