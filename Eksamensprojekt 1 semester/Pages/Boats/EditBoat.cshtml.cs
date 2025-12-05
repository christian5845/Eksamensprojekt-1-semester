using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.Boats
{
    public class EditBoatModel : PageModel
    {
        private IBoatRepository _boatRepository;

        [BindProperty]
        public Boat Boat { get; set; }

        public EditBoatModel(IBoatRepository boatRepository)
        {
            _boatRepository = boatRepository;
        }

        public IActionResult OnGet(int id)
        {
            Boat = _boatRepository.GetBoat(id);
            if (Boat == null)
                return RedirectToPage("/NotFound");
            
            return Page();
        }

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
