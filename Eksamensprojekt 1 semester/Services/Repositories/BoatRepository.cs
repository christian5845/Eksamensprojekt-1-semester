using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.MockData;
using Eksamensprojekt_1_semester.Services.Interfaces;

namespace Eksamensprojekt_1_semester.Services.Repositories
{
    public class BoatRepository : IBoatRepository
    {
        private List<Boat> _boats;

        public BoatRepository()
        {
            _boats = MockBoats.GetMockBoats();
        }

        public List<Boat> GetBoats()
        {
            return _boats;
        }

        public void AddBoat(Boat boat)
        {
            _boats.Add(boat);
        }
    }
}
