using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.Boats
{
    public class EditBoatModel : PageModel
    {
        private IBoatRepository _boatRepository;

        // Property til at binde båden, der skal redigeres.
        [BindProperty]
        public Boat Boat { get; set; }

        public EditBoatModel(IBoatRepository boatRepository)
        {
            _boatRepository = boatRepository;
        }

        // Hent båden baseret på dens ID ved GET-anmodning.
        public IActionResult OnGet(int id)
        {
            Boat = _boatRepository.GetBoat(id);
            if (Boat == null)
                return RedirectToPage("/NotFound");
            
            return Page();
        }

        // Opdater båden ved POST-anmodning.
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _boatRepository.UpdateBoat(Boat);
            return RedirectToPage("GetAllBoats");
        }
    }
}
