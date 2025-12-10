using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.OurBoats;

public class GetOurBoatsModel : PageModel
{
    private IBoatRepository _boatRepository;


    [BindProperty]
    public List<string> BoatTypes { get; set; }
    public List<Boat> Boats { get; private set; }

    public GetOurBoatsModel(IBoatRepository boatRepository)
    {
        _boatRepository = boatRepository;
        Boats = _boatRepository.GetBoats();
    }

    public void OnGet()
    {
        BoatTypes = new List<string>();
    }
    public void AddType(string type)
    {
        BoatTypes.Add(type);
    }
}
