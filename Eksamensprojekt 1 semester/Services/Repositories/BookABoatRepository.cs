using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.MockData;
using Eksamensprojekt_1_semester.Services.Json;

namespace Eksamensprojekt_1_semester.Services.Repositories;

public class BookABoatRepository : IBookABoatRepository
{
    #region Instancefields
    private List<Boat> _boats;
    private JsonFileBoatService _jsonFileBoatService;
    private List<Booking> _booking;
    private JsonFileBookingService _jsonFileBookingService;
    private IIDLogRepository _iDLogRepository;
    #endregion

    #region Constructor
    public BookABoatRepository(JsonFileBoatService jsonFileBoatService, JsonFileBookingService jsonFileBookingService,IIDLogRepository iIDLogRepository)
    {
        _jsonFileBoatService = jsonFileBoatService;
        _jsonFileBookingService = jsonFileBookingService;
        _iDLogRepository = iIDLogRepository;
        _boats = jsonFileBoatService.GetJsonBoats().ToList();
        _booking = _jsonFileBookingService.GetJsonBookings().ToList();
    }
    #endregion

    #region Methods
    public void AddABooking(Booking booking)
    {
        booking.BookingId = _iDLogRepository.GetNewBookingID();
        _booking.Add(booking);
        _jsonFileBookingService.SaveJsonBookings(_booking);
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

    public Boat GetBoat(int id)
    {
        foreach (Boat boat in _boats)
        {
            if (boat.Id == id)
                return boat;
        }

        return null;
    }

    public List<Boat> GetBoats()
    {
        return _boats;
    }
    #endregion
}
