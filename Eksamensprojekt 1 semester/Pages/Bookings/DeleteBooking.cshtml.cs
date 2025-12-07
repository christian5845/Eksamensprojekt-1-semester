using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Models;


namespace Eksamensprojekt_1_semester.Pages.Bookings
{
    public class DeleteBookingsModel : PageModel
    {
        private IBookABoatRepository _bookABoatRepository;

        public DeleteBookingsModel(IBookABoatRepository bookABoatRepository)
        {
            _bookABoatRepository = bookABoatRepository;
        }

        [BindProperty]
        public Booking booking { get; set; }

        public IActionResult OnGet(string name)
        {
            booking = _bookABoatRepository.GetBookedBoats(name);
            if (booking == null)
                return RedirectToPage("/NotFound");

            return Page();
        }

        public IActionResult OnPost()
        {
            Booking deletedBooking = _bookABoatRepository.DeleteBooking(booking.Name);
            if (deletedBooking == null)
                return RedirectToPage("/NotFound");

            return RedirectToPage("BookedBoats");
        }
    }
}

