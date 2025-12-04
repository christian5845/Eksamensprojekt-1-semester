using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.Boats
{
    public class CreateBoatModel : PageModel
    {
        private IBoatRepository _boatRepository;
        [BindProperty]
        public Boat Boat { get; set; }
        public CreateBoatModel(IBoatRepository boatRepository)
        {
            _boatRepository = boatRepository;
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
            _boatRepository.AddBoat(Boat);
            return RedirectToPage("GetAllBoats");
        }
    }
}
