using System;

namespace FInal_IUIS.Entities
{
    public class Course
    {
        public string CourseId { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public int Credits { get; set; }
        public string Department { get; set; }
        public int Duration { get; set; }
        public bool IsActive { get; set; }
    }
}
