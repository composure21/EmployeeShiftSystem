using Microsoft.AspNetCore.Mvc;
using EmployeeShiftSystem.Data;
using EmployeeShiftSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeShiftSystem.Services
{
    public class ShiftService
    {
        private readonly AppDbContext _context;

        public ShiftService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> HasConflict(int employeeId, DateTime start, DateTime end)
        {
            return await _context.Shifts
                .AnyAsync(s => s.EmployeeId == employeeId &&
                              start < s.EndTime &&
                              end > s.StartTime);
        }
    }
}