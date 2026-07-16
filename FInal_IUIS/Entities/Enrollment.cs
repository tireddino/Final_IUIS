using System;

namespace FInal_IUIS.Entities
{
    public class Enrollment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string CourseId { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string Status { get; set; }
        public decimal Grade { get; set; }
        public DateTime CompletionDate { get; set; }
    }
}
