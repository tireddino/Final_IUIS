using System;

namespace FInal_IUIS.Entities
{
    public class Clearance
    {
        public string ClearanceId { get; set; }
        public string StudentId { get; set; }
        public DateTime IssueDate { get; set; }
        public bool LibraryClearance { get; set; }
        public bool AccountingClearance { get; set; }
        public bool DisciplineClearance { get; set; }
        public bool MedicalClearance { get; set; }
        public bool DepartmentClearance { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
    }
}
