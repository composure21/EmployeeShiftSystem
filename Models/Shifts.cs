using Microsoft.AspNetCore.Mvc;

namespace EmployeeShiftSystem.Models
{
    public class Shift
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
