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

        public Boat GetBoat(int id)
        {
            foreach (Boat boat in _boats)
            {
                if (boat.Id == id)
                    return boat;
            }

            return null;
        }

        public void UpdateBoat(Boat boat)
        {
            if (boat != null)
            {
                foreach (Boat b in _boats)
                {
                    if (b.Id == boat.Id)
                    {
                        b.Type = boat.Type;
                        b.Size = boat.Size;
                        b.PricePerDay = boat.PricePerDay;
                    }
                }
            }
        }

        public Boat DeleteBoat (int? boatId)
        {
            foreach (Boat boat in _boats)
            {
                if (boat.Id == boatId)
                {
                    _boats.Remove(boat);
                    return boat;
                }
            }

            return null;
        }

        public IEnumerable<Boat> GetBoatByType(string type)
        {
            List<Boat> typeSearch = new List<Boat>();
            foreach (Boat boat in _boats)
            {
                if (string.IsNullOrEmpty(type) || boat.Type.ToLower().Contains(type.ToLower()))
                {
                    typeSearch.Add(boat);
                }
            }
            return typeSearch;
        }

        public IEnumerable<Boat> PriceFilter(double maxPrice, double minPrice = 0)
        {
            List<Boat> filterList = new List<Boat>();
            foreach (Boat boat in _boats)
            {
                if ((minPrice == 0 && boat.PricePerDay <= maxPrice) ||
                    (maxPrice == 0 && boat.PricePerDay >= minPrice) ||
                    (boat.PricePerDay >= minPrice && boat.PricePerDay <= maxPrice))
                {
                    filterList.Add(boat);
                }
            }

            return filterList;
        }
    }
}
