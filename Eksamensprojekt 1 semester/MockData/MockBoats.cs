using Eksamensprojekt_1_semester.Models;

namespace Eksamensprojekt_1_semester.MockData
{
    public class MockBoats
    {
        private static List<Boat> _boats = new List<Boat>
        {
            new Boat(1, "TEVA", "Stor", 1000.0),
            new Boat(2, "WAVE", "Lille", 500.0),
            new Boat(3, "SURFER", "Mellem", 750.0),
            new Boat(4, "SPEEDY", "Stor", 1200.0),
            new Boat(5, "FLOATY", "Lille", 600.0),
        };
        public static List<Boat> GetMockBoats() { return _boats; }
    }
}
