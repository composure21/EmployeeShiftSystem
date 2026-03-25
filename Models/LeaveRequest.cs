using Microsoft.AspNetCore.Mvc;

namespace EmployeeShiftSystem.Models
{
    public class LeaveRequest
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Status { get; set; } = "Pending"; // Approved / Rejected
    }
}
