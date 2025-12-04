using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Eksamensprojekt_1_semester.MockData;

namespace Eksamensprojekt_1_semester.Pages;

public class PHBådemedbeskrivelserModel : PageModel
{

    public List<MockBoats> Boats { get; private set; }
  
    public void OnGet()
    {
        Boats = MockBoats.GetMockBoats();
    }
}
