using Eksamensprojekt_1_semester.Models;

namespace Eksamensprojekt_1_semester.Services.Interfaces
{
    public interface IBookABoatRepository
    {
        void AddABooking(Booking booking);      
        Booking DeleteBooking(string name);
        List<Booking> GetBookedBoats();
        Booking GetBookedBoats(string name);

        List<Boat> GetBoats();
        Boat GetBoat(int id);
    }
}
