using System;

namespace FInal_IUIS.Entities
{
    public class Course
    {
        public string Id { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public string Description { get; set; }
        public int Credits { get; set; }
        public string Instructor { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MaxStudents { get; set; }
        public bool IsActive { get; set; }
    }
}
