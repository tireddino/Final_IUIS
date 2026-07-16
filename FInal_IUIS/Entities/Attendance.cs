using System;

namespace FInal_IUIS.Entities
{
    public class Attendance
    {
        public string AttendanceId { get; set; }
        public string EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan TimeIn { get; set; }
        public TimeSpan? TimeOut { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
    }
}
