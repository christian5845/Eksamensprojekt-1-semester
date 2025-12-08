using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Eksamensprojekt_1_semester.MockData;
using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;

namespace Eksamensprojekt_1_semester.Pages.Bookings;

public class BookedBoatsModel : PageModel
{
    private IBookABoatRepository _bookingRepository;

    public List<Booking> Booking { get; private set; }

    public BookedBoatsModel(IBookABoatRepository bookingRepository)
    {
        _bookingRepository = bookingRepository;
    }

    public void OnGet()
    {
        Booking = _bookingRepository.GetBookedBoats();
    }
}