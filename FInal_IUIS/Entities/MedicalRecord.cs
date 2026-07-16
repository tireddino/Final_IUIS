using System;

namespace FInal_IUIS.Entities
{
    public class MedicalRecord
    {
        public string RecordId { get; set; }
        public string StudentId { get; set; }
        public DateTime ConsultationDate { get; set; }
        public string Complaint { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public string Medication { get; set; }
        public string AttendingPhysician { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
    }
}
