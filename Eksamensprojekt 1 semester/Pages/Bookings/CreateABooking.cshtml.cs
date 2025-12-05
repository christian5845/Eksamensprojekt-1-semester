using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.Bookings;

public class CreateABookingModel : PageModel
{
    private IBookABoatRepository _iBookABoatRepository;

    [BindProperty]
    public Booking BookedBoat { get; set; }
    public CreateABookingModel(IBookABoatRepository iBookABoatRepository)
        {
            _iBookABoatRepository = iBookABoatRepository;
        }
    public IActionResult OnGet()
    {
        return Page();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _iBookABoatRepository.AddABooking(BookedBoat);
        return RedirectToPage("GetAllMembers");
    }
}
