using Eksamensprojekt_1_semester.Models;

namespace Eksamensprojekt_1_semester.MockData
{
    public static class MockBooking
    {
        private static List<Booking> _bookings = new List<Booking>
        {
            new Booking("Jesper", new DateOnly (2025, 1, 2), new DateOnly (2025, 1, 2), "kattegat", new Boat( "TEVA", "Stor", 1000.0)),
            new Booking("Bo", new DateOnly (2025, 1, 19), new DateOnly (2025, 1, 25), "kattegat", new Boat( "WAVE", "Lille", 500.0)),
            new Booking("kalle", new DateOnly (2025, 4, 27), new DateOnly (2025, 4, 28), "kattegat", new Boat( "SURFER", "Mellem", 750.0))
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
