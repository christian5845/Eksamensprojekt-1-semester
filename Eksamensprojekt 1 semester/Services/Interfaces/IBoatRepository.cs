using Eksamensprojekt_1_semester.Models;

namespace Eksamensprojekt_1_semester.Services.Interfaces
{
    public interface IBoatRepository
    {
        List<Boat> GetBoats();
        void AddBoat(Boat boat);
        void UpdateBoat(Boat boat);
        Boat GetBoat (int id);
        Boat DeleteBoat (int? boatId);
        IEnumerable<Boat> GetBoatByType(string type);
        IEnumerable<Boat> PriceFilter(double maxPrice, double minPrice = 0);
    }
}
