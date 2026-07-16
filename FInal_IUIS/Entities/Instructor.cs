namespace FInal_IUIS.Entities
{
    public class Instructor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Department { get; set; }
        public string Specialization { get; set; }
        public DateTime HireDate { get; set; }
        public bool IsActive { get; set; }
    }
}
