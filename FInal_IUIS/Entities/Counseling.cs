using System;

namespace FInal_IUIS.Entities
{
    public class Counseling
    {
        public string CounselingId { get; set; }
        public string StudentId { get; set; }
        public string CounselorId { get; set; }
        public DateTime SessionDate { get; set; }
        public string SessionType { get; set; }
        public string Concern { get; set; }
        public string Recommendations { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
    }
}
