namespace SchoolFaceControllApp.Models.Main
{
    public class Employee : Person
    {
        public decimal Price { get; set; }
        public int? DutyId { get; set; }
        public Duty? Duty { get; set; }
    }
}
