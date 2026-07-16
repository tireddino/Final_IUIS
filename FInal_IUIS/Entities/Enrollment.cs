using System;

namespace FInal_IUIS.Entities
{
    public class Enrollment
    {
        public string EnrollmentId { get; set; }
        public string StudentId { get; set; }
        public string SubjectId { get; set; }
        public string CourseId { get; set; }
        public string AcademicYear { get; set; }
        public string Semester { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string Status { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal Balance { get; set; }
    }
}
