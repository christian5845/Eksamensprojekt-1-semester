using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.MockData;

namespace Eksamensprojekt_1_semester.Services.Repositories;

public class BookABoatRepository : IBookABoatRepository
{
    #region Instancefields
    private List<Booking> _booking;
    private IIDLogRepository _iDLogRepository;
    #endregion

    #region Constructor
    public BookABoatRepository(IIDLogRepository iIDLogRepository)
    {
        _iDLogRepository = iIDLogRepository;
        _booking = MockBooking.GetMockBooking();
    }
    #endregion

    #region Methods
    public void AddABooking(Booking booking)
    {
        booking.BookingId = _iDLogRepository.GetNewBookingID();
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
    #endregion
}
