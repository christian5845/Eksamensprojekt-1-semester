using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.MockData;
using Eksamensprojekt_1_semester.Services.Repositories;
using Eksamensprojekt_1_semester.Services.Interfaces;
namespace Eksamensprojekt_1_semester.Pages.Booking;

public class CreateABookingModel : PageModel
{
    private IBookABoatRepository _iBookABoatRepository;
    
    [BindProperty]
    public Booking Booking;

    public void OnGet()
    {

    }

    public CreateABookingModel(IBookABoatRepository iBookABoatRepository)
    {
        _iBookABoatRepository = iBookABoatRepository;
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _iBookABoatRepository.AddABoat(boat);
        return RedirectToPage("GetAllMembers");
    }
}
