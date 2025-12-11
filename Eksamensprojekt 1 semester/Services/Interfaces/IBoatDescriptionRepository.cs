using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Pages.Boats;

namespace Eksamensprojekt_1_semester.Services.Interfaces;

public interface IBoatDescriptionRepository
{
    
    List<Boat> GetBoats();

    List<BoatDescription> GetBoatDescriptions();

    void EditBoatDescription(BoatDescription boatDescription);
}
