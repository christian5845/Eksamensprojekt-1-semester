using Eksamensprojekt_1_semester.Models;

namespace Eksamensprojekt_1_semester.Services.Interfaces;
//Christian, Rasmus, Søren
public interface IBookABoatRepository
{
    void AddABooking(Booking booking);      
    Booking DeleteBooking(int bookingID);
    List<Booking> GetBookedBoats();
    Booking GetBookedBoats(int id);
    List<Member> GetMembers();
    List<Boat> GetBoats();
    Boat GetBoat(int id);
}
