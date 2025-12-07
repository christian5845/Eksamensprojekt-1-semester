using Eksamensprojekt_1_semester.Models;

namespace Eksamensprojekt_1_semester.MockData
{
    public static class MockBooking
    {
        private static List<Booking> _bookings = new List<Booking>
        {
            new Booking("Jesper", "3. januar", new Boat(1, "TEVA", "Stor", 1000.0)),
            new Booking("Bo", "19. december", new Boat(2, "WAVE", "Lille", 500.0)),
            new Booking("kalle", "27. december", new Boat(3, "SURFER", "Mellem", 750.0))
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
