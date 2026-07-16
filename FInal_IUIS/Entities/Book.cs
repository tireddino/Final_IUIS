using System;

namespace FInal_IUIS.Entities
{
    public class Book
    {
        public string BookId { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime PublishYear { get; set; }
        public string Category { get; set; }
        public int TotalCopies { get; set; }
        public int AvailableCopies { get; set; }
        public string Location { get; set; }
        public bool IsActive { get; set; }
    }
}
