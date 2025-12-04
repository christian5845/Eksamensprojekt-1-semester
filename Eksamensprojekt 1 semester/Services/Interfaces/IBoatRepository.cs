using Eksamensprojekt_1_semester.Models;

namespace Eksamensprojekt_1_semester.Services.Interfaces
{
    public interface IBoatRepository
    {
        List<Boat> GetBoats();
        void AddBoat(Boat boat);
    }
}
