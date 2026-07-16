using System;

namespace FInal_IUIS.Entities
{
    public class Payment
    {
        public string PaymentId { get; set; }
        public string EnrollmentId { get; set; }
        public string StudentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string ReferenceNumber { get; set; }
        public string PaidBy { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
    }
}
