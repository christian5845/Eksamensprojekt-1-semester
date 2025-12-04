using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Eksamensprojekt_1_semester.MockData;

namespace Eksamensprojekt_1_semester.Pages.Booking
{
    public class BookedBoatsModel : PageModel
    {
        public List<Models.Booking> Booking { get; private set; }

        public void OnGet()
        {
            Booking = MockBooking.GetMockBooking();
        }
    }
}
