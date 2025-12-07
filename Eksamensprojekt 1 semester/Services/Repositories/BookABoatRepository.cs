using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.MockData;

namespace Eksamensprojekt_1_semester.Services.Repositories
{
    public class BookABoatRepository : IBookABoatRepository
    {
        private List<Booking> _booking;

        public BookABoatRepository()
        {
            _booking = MockBooking.GetMockBooking();
        }
        public void AddABooking(Booking booking)
        {
            _booking.Add(booking);
        }

        public List<Booking> GetBookedBoats()
        {
            return _booking;
        }

        public Booking GetBookedBoats(string name)
        {
            foreach (Booking booking in _booking)
            {
                if (booking.Name == name)
                    return booking;
            }

            return null;
        }

        public Booking DeleteBooking(string name)
        {
            foreach (Booking booking in _booking)
            {
                if (booking.Name == name)
                {
                    _booking.Remove(booking);
                    return booking;
                }
            }

            return null;
        } 
    }
}
