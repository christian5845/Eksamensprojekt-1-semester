using Eksamensprojekt_1_semester.MockData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.Bookings;

public class BookedBoatsModel : PageModel
{
    public List<Models.Booking> Booking { get; private set; }

    public void OnGet()
    {
        Booking = MockBooking.GetMockBooking();
    }
}