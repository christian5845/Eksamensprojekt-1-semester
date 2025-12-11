using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.BoatDescriptions;

public class GetAllBoatDescriptionsModel : PageModel
{
    private IBoatDescriptionRepository _boatDescriptionRepository;


    [BindProperty]
    public List<Boat> Boats { get; private set; }

    public List<BoatDescription> BoatDescriptions { get; set; }

    public GetAllBoatDescriptionsModel(IBoatDescriptionRepository boatDescriptionRepository)
    {
        _boatDescriptionRepository = boatDescriptionRepository;
    }

    public void OnGet()
    {
        Boats = _boatDescriptionRepository.GetBoats();
        BoatDescriptions = _boatDescriptionRepository.GetBoatDescriptions();
    }
   
}
