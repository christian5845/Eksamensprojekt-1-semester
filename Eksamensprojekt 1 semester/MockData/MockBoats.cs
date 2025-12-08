using Eksamensprojekt_1_semester.Models;

namespace Eksamensprojekt_1_semester.MockData
{
    public class MockBoats
    {
        private static List<Boat> _boats = new List<Boat>
        {
            new Boat("TEVA", "Stor", 1000.0),
            new Boat("WAVE", "Lille", 500.0),
            new Boat("SURFER", "Mellem", 750.0),
            new Boat("SPEEDY", "Stor", 1200.0),
            new Boat("FLOATY", "Lille", 600.0),
        };
        public static List<Boat> GetMockBoats() { return _boats; }

        public static void AddABoat(Boat boat)
        {
            _boats.Add(boat);
        }

        public static Boat? GetBoat(int boatID)
        {
            foreach(Boat boat in _boats)
            {
                if(boat.Id==boatID)
                {
                    return boat;
                }
            }
            return null;
        }
    }


}

