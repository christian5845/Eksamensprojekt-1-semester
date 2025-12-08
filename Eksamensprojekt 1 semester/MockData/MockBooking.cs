using Eksamensprojekt_1_semester.Models;

namespace Eksamensprojekt_1_semester.MockData
{
    public static class MockBooking
    {
        private static List<Booking> _bookings = new List<Booking>
        {
            //new Booking("Jesper", new DateOnly (2025, 1, 2), new Boat("TEVA", "Stor", 1000.0)),
            //new Booking("Bo", new DateOnly (2025, 12, 19), new Boat("WAVE", "Lille", 500.0)),
            //new Booking("kalle", new DateOnly (2025, 12, 27), new Boat("SURFER", "Mellem", 750.0))
        };
        public static List<Booking> GetMockBooking() 
        { 
            return _bookings;
        }

        public static void AddABooking(Booking booking)
        {
            _bookings.Add(booking);
        }

        
    }
}
