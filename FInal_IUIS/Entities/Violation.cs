using System;

namespace FInal_IUIS.Entities
{
    public class Violation
    {
        public string ViolationId { get; set; }
        public string StudentId { get; set; }
        public DateTime ViolationDate { get; set; }
        public string ViolationType { get; set; }
        public string Description { get; set; }
        public string Sanction { get; set; }
        public string Status { get; set; }
        public string ReportedBy { get; set; }
        public string Remarks { get; set; }
    }
}
