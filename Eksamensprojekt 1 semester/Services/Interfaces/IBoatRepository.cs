using Eksamensprojekt_1_semester.Models;

namespace Eksamensprojekt_1_semester.Services.Interfaces;

// Interfaces beskriver hvilke metoder en repository skal implementere.
// Altså hvilke funktionaliteter der skal være tilgængelige for at arbejde med Boat-objekter, men ikke hvordan de virker.
// Det dertilhørende repository SKAL implementere disse metoder.
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
