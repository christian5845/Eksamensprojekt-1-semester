using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.BoatDescriptions;
//Rasmus
public class GetAllBoatDescriptionsModel : PageModel
{
    #region InstanceFields
    private IBoatDescriptionRepository _boatDescriptionRepository;
    #endregion

    #region Properties
    [BindProperty]
    public List<Boat> Boats { get; private set; }
    #endregion

    #region Constructors
    public List<BoatDescription> BoatDescriptions { get; set; }

    public GetAllBoatDescriptionsModel(IBoatDescriptionRepository boatDescriptionRepository)
    {
        _boatDescriptionRepository = boatDescriptionRepository;
    }
    #endregion

    #region Methods
    public void OnGet()
    {
        Boats = _boatDescriptionRepository.GetBoats();
        BoatDescriptions = _boatDescriptionRepository.GetBoatDescriptions();
    }
    #endregion
}
