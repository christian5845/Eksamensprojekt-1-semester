using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Models;


namespace Eksamensprojekt_1_semester.Pages.Bookings;

public class DeleteBookingsModel : PageModel
{
    #region Instancefields
    private IBookABoatRepository _bookABoatRepository;
    #endregion

    #region Constructors
    [BindProperty]
    public Booking booking { get; set; }
    #endregion

    #region Constructors
    public DeleteBookingsModel(IBookABoatRepository bookABoatRepository)
    {
        _bookABoatRepository = bookABoatRepository;
    }
    #endregion

    #region Methods
    public IActionResult OnGet(int id)
    {
        booking = _bookABoatRepository.GetBookedBoats(id);
        if (booking == null)
        {
            return RedirectToPage("BookedBoats");
        }
        return Page();
    }

    public IActionResult OnPost()
    {
        Booking deletedBooking = _bookABoatRepository.DeleteBooking(booking.BookingId);
        if (deletedBooking == null)
            return RedirectToPage("BookedBoats");

        return RedirectToPage("BookedBoats");
    }
    #endregion
}

