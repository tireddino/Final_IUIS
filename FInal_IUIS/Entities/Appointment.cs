using System;

namespace FInal_IUIS.Entities
{
    public class Appointment
    {
        public string AppointmentId { get; set; }
        public string StudentId { get; set; }
        public string StaffId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Purpose { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
    }
}
