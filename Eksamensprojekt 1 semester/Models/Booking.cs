namespace Eksamensprojekt_1_semester.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public double? Price { get { return BookedBoat.PricePerDay; } }
        public Boat BookedBoat { get; set; } // Changed from get-only to get; set;

        public Booking() { }

        public Booking(string name, DateTime date, Boat bookedboat)
        {
            Name = name;
            Date = new DateTime(date.Year, date.Month, date.Day);
            BookedBoat = bookedboat;
        }
       
    }
}
