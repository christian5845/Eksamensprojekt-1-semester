namespace Eksamensprojekt_1_semester.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public double Price { get; set; }
        public Boat BookedBoat { get; set; } // Changed from get-only to get; set;

        public Booking() { }

        public Booking(string name, string date, Boat bookedboat)
        {
            Name = name;
            Date = date;
            BookedBoat = bookedboat;
        }
       
    }
}
