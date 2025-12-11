using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Pages.Boats;

namespace Eksamensprojekt_1_semester.Services.Interfaces;

public interface IBoatDescriptionRepository
{
    Boat GetBoat(int id);
}
