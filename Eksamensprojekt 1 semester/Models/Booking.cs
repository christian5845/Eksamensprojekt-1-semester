namespace Eksamensprojekt_1_semester.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public string Name { get; set; }
        public DateOnly DateStart { get; set; }
        public DateOnly DateEnd { get; set; }
        public double Price { get; set; }
        public Boat BookedBoat { get; set; } // Changed from get-only to get; set;
        public double TotalPris
        {
            get
            {
                int antalDage = (DateEnd.DayNumber - DateStart.DayNumber) + 1;
                return antalDage * (BookedBoat?.PricePerDay ?? 0);
            }
        }
        public Booking() { }

        public Booking(string name, DateOnly datestart, DateOnly dateend, Boat bookedboat)
        {
            Name = name;
            BookedBoat = bookedboat;
            DateStart = datestart;
            DateEnd = dateend;
        }
       
    }
}
