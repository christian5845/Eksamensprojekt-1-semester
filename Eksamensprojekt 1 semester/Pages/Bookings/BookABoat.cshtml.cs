using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.Bookings;

public class BookABoatModel : PageModel 
{
    private IBookABoatRepository _ibookABoatRepository;
        [BindProperty]
    public List<Boat> BookABoat { get; set; }

    public BookABoatModel(IBookABoatRepository ibookABoatRepository)
    {
        _ibookABoatRepository = ibookABoatRepository;
        BookABoat = _ibookABoatRepository.GetBoats();
    }

    public void OnGet()
    {
       
    }

}
