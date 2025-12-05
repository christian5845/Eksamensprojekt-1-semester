using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.MockData;


namespace Eksamensprojekt_1_semester.Pages;

public class PHBådemedbeskrivelserModel : PageModel
{
    [BindProperty]
    public List<string> BoatTypes { get; set; }
    public List<Boat> Boats { get; private set; }
  
    public void OnGet()
    {
        Boats = MockBoats.GetMockBoats();
        BoatTypes = new List<string>();
    }
    public void AddType(string type)
    {
        BoatTypes.Add(type);
    }
}
