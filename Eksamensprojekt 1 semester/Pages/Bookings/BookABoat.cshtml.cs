using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.Bookings;
//Søren, Christian, Rasmus
public class BookABoatModel : PageModel 
{
    #region InstanceFields
    private IBookABoatRepository _ibookABoatRepository;
    #endregion

    #region Properties
    [BindProperty]
    public List<Boat> BookABoat { get; set; }
    #endregion

    #region COnstructors
    public BookABoatModel(IBookABoatRepository ibookABoatRepository)
    {
        _ibookABoatRepository = ibookABoatRepository;
        BookABoat = _ibookABoatRepository.GetBoats();
    }
    #endregion
}
