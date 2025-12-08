namespace Eksamensprojekt_1_semester.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public string Name { get; set; }
        public DateOnly Date { get; set; }
        public double Price { get; set; }
        public Boat BookedBoat { get; set; } // Changed from get-only to get; set;

    public Booking() { }

        public Booking(string name, DateOnly date, Boat bookedboat)
        {
            Name = name;
            BookedBoat = bookedboat;
            Date = date;
        }
       
    }
}
