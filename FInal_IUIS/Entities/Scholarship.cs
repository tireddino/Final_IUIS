using System;

namespace FInal_IUIS.Entities
{
    public class Scholarship
    {
        public string ScholarshipId { get; set; }
        public string StudentId { get; set; }
        public string ScholarshipType { get; set; }
        public string Sponsor { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateAwarded { get; set; }
        public string AcademicYear { get; set; }
        public string Semester { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
    }
}
