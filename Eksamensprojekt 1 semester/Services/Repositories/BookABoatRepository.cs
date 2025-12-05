using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.MockData;
namespace Eksamensprojekt_1_semester.Services.Repositories
{
    public class BookABoatRepository : IBookABoatRepository
    {
        public void AddABooking(Booking booking)
        {
            MockBooking.AddABooking(booking);
        }
    }
}
