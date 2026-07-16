using System;

namespace FInal_IUIS.Entities
{
    public class Subject
    {
        public string SubjectId { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public string Description { get; set; }
        public int Units { get; set; }
        public string Prerequisite { get; set; }
        public string CourseId { get; set; }
        public string InstructorId { get; set; }
        public string Schedule { get; set; }
        public string Room { get; set; }
        public int MaxStudents { get; set; }
        public bool IsActive { get; set; }
    }
}
