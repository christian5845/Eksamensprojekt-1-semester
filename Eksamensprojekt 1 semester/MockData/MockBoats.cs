using Eksamensprojekt_1_semester.Models;

namespace Eksamensprojekt_1_semester.MockData
{
    public class MockBoats
    {
        private static List<Boat> _boats = new List<Boat>
        {
            new Boat(1, "TEVA", "Stor"),
            new Boat(2, "WAVE", "Lille"),
            new Boat(3, "SURFER", "Mellem"),
            new Boat(4, "SPEEDY", "Stor"),
            new Boat(5, "FLOATY", "Lille"),
        };
        public static List<Boat> GetMockBoats() { return _boats; }
    }
}
