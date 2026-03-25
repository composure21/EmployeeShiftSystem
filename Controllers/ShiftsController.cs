using EmployeeShiftSystem.Models;
using Microsoft.AspNetCore.Mvc;
using EmployeeShiftSystem.Data;
using EmployeeShiftSystem.Services;

namespace EmployeeShiftSystem.Controllers
{
    [ApiController]
    [Route("api/shifts")]
    public class ShiftsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ShiftService _shiftService;

        public ShiftsController(AppDbContext context, ShiftService shiftService)
        {
            _context = context;
            _shiftService = shiftService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateShift(Shift shift)
        {
            if (await _shiftService.HasConflict(shift.EmployeeId, shift.StartTime, shift.EndTime))
                return BadRequest("Shift conflict detected");

            _context.Shifts.Add(shift);
            await _context.SaveChangesAsync();
            return Ok(shift);
        }

        [HttpGet]
        public IActionResult GetShifts()
        {
            return Ok(_context.Shifts.ToList());
        }
    }
}
