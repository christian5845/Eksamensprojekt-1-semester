using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
#nullable disable

namespace Eksamensprojekt_1_semester.Pages.Boats
{
    public class DeleteBoatModel : PageModel
    {
        private IBoatRepository _boatRepository;

        public DeleteBoatModel(IBoatRepository boatRepository)
        {
            _boatRepository = boatRepository;
        }

        [BindProperty]
        public Boat Boat { get; set; }

        public IActionResult OnGet(int id)
        {
            Boat = _boatRepository.GetBoat(id);
            if (Boat == null)
                return RedirectToPage("/NotFound");
            
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            Boat deletedBoat = _boatRepository.DeleteBoat(Boat.Id);
            if (deletedBoat == null)
                return RedirectToPage("/NotFound");

            return RedirectToPage("GetAllBoats");
        }
    }
}
