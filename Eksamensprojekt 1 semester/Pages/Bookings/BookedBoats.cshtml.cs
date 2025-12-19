using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Eksamensprojekt_1_semester.MockData;
using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;

namespace Eksamensprojekt_1_semester.Pages.Bookings;

public class BookedBoatsModel : PageModel
{
    #region Instancefields
    private IBookABoatRepository _bookingRepository;
    #endregion

    #region Properties
    public List<Booking> Booking { get; private set; }
    #endregion

    #region Constructors
    public BookedBoatsModel(IBookABoatRepository bookingRepository)
    {
        _bookingRepository = bookingRepository;
    }
    #endregion

    #region Methods
    public void OnGet()
    {
        Booking = _bookingRepository.GetBookedBoats();
    }

    public IActionResult OnPostToggle(int id)
    {
        if (id <= 0)
        {
            return RedirectToPage();
        }

        var booking = _bookingRepository.GetBookedBoats(id);
        if (booking != null)
        {
            booking.AnkommetHjem = !booking.AnkommetHjem;
        }

        return RedirectToPage();
    }
    #endregion
}