using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Pages.Boats;

namespace Eksamensprojekt_1_semester.Services.Interfaces;
//Rasmus
public interface IBoatDescriptionRepository
{
    void AddBoatDescription(string type);
    List<Boat> GetBoats();
    Boat GetBoat(int id);
    List<BoatDescription> GetBoatDescriptions();
    void EditBoatDescription(BoatDescription boatDescription);
}
