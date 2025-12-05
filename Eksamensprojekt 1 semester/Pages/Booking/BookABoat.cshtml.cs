using Eksamensprojekt_1_semester.MockData;
using Eksamensprojekt_1_semester.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.Booking;


public class BookABoatModel : PageModel
{
    [BindProperty]
    public List<Boat> BookABoat { get; set; }

    public void OnGet()
    {
        BookABoat = MockBoats.GetMockBoats();
    }
}
