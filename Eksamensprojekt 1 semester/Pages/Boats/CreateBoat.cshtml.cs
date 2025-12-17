using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.Boats
{
    public class CreateBoatModel : PageModel
    {
        private IBoatRepository _boatRepository;

        // Property til at binde den nye båd.
        [BindProperty]
        public Boat Boat { get; set; }
        
        public CreateBoatModel(IBoatRepository boatRepository)
        {
            _boatRepository = boatRepository;
        }

        // Vis siden ved GET-anmodning.
        public IActionResult OnGet()
        {
            return Page();
        }

        // Opret den nye båd ved POST-anmodning.
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _boatRepository.AddBoat(Boat);
            return RedirectToPage("GetAllBoats");
        }
    }
}
