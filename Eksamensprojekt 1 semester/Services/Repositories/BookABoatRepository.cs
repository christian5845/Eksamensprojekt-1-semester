using Eksamensprojekt_1_semester.MockData;
using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Services.Json;
using System.Xml.Linq;

namespace Eksamensprojekt_1_semester.Services.Repositories;
//Rasmus, Christian, Søren

public class BookABoatRepository : IBookABoatRepository
{
    #region Instancefields
    private List<Boat> _boats;
    private List<Member> _memberList;
    private JsonFileBoatService _jsonFileBoatService;
    private List<Booking> _booking;
    private JsonFileBookingService _jsonFileBookingService;
    private IIDLogRepository _iDLogRepository;
    private JsonFileMemberService _jsonFileMemberService;
    #endregion

    #region Constructor
    public BookABoatRepository(JsonFileBoatService jsonFileBoatService, JsonFileBookingService jsonFileBookingService,IIDLogRepository iIDLogRepository, JsonFileMemberService jsonFileMemberService)
    {
        _jsonFileBoatService = jsonFileBoatService;
        _jsonFileBookingService = jsonFileBookingService;
        _jsonFileMemberService = jsonFileMemberService;
        _iDLogRepository = iIDLogRepository;
        _boats = _jsonFileBoatService.GetJsonBoats().ToList();
        _booking = _jsonFileBookingService.GetJsonBookings().ToList();
        _memberList = _jsonFileMemberService.GetJsonMembers().ToList();
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

    public Booking GetBookedBoats(int id)
    {
        foreach (Booking booking in _booking)
        {
            if (booking.BookingId == id)
                return booking;
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

    public Booking DeleteBooking(int bookingID)
    {
        foreach (Booking booking in _booking)
        {
            if (booking.BookingId == bookingID)
            {
                _booking.Remove(booking);
                return booking;
            }
        }
        return null;
    }

    public List<Member> GetMembers()
    {
        return _memberList;
    }
    #endregion
}
