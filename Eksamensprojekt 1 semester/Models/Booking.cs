namespace Eksamensprojekt_1_semester.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public double Price { get; set; }

        public Booking() { }

        public Booking(string name, string date)
        {
            Name = name;
            Date = date;
        }
    }
}
