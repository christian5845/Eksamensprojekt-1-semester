using Eksamensprojekt_1_semester.Models;

namespace Eksamensprojekt_1_semester.MockData
{
    public class MockBooking
    {
        private static List<Booking> _booking = new List<Booking>
        {
            new Booking("Jesper", "3. januar", new Boat(1, "TEVA", "Stor")),
            new Booking("Bo", "19. december",new Boat()),
            new Booking("kalle", "27. december",new Boat())
        };
        public static List<Booking> GetMockBooking() { return _booking; }



    }
}
