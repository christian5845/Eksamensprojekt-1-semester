using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
#nullable disable

namespace Eksamensprojekt_1_semester.Pages.Boats;
//Jonas
public class DeleteBoatModel : PageModel
{
    #region Instancefields
    private IBoatRepository _boatRepository;
    #endregion

    #region Properties
    // Property til at binde båden, der skal slettes.
    [BindProperty]
    public Boat Boat { get; set; }
    #endregion

    #region Constructors
    public DeleteBoatModel(IBoatRepository boatRepository)
    {
        _boatRepository = boatRepository;
    }
    #endregion

    #region Methods
    // Hent båden baseret på dens ID ved GET-anmodning.
    public IActionResult OnGet(int id)
    {
        Boat = _boatRepository.GetBoat(id);
        if (Boat == null)
            return RedirectToPage("/NotFound");
        
        return Page();
    }

    // Slet båden ved POST-anmodning.
    public IActionResult OnPost(int id)
    {
        Boat deletedBoat = _boatRepository.DeleteBoat(Boat.Id);
        if (deletedBoat == null)
            return RedirectToPage("/NotFound");

        return RedirectToPage("GetAllBoats");
    }
    #endregion
}
