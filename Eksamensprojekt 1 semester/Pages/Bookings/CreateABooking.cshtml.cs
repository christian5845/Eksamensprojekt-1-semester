using Eksamensprojekt_1_semester.MockData;
using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Services.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.Bookings;

public class CreateABookingModel : PageModel
{
    private IBookABoatRepository _iBookABoatRepository;

    [BindProperty]
    public Booking TheBooking { get; set; }
    [BindProperty]
    public Boat TheBookedBoat { get; set; }
    public CreateABookingModel(IBookABoatRepository iBookABoatRepository)
        {
            _iBookABoatRepository = iBookABoatRepository;
        }
    public IActionResult OnGet(int id)
    {
        TheBookedBoat = MockBoats.GetBoat(id);
        if (TheBookedBoat == null)
            return RedirectToPage("/BookABoat");
        return Page();
    }

    public IActionResult OnPost()
    {
    
        AddBoatToBooking(TheBookedBoat);
        _iBookABoatRepository.AddABooking(TheBooking);
        return RedirectToPage("/BookABoat");
    }

    public void AddBoatToBooking(Boat boat)
    {
        TheBooking.BookedBoat = boat;
    }
}
