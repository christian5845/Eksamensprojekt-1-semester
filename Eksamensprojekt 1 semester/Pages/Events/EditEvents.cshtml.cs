using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.Events;
//Søren
public class EditEventModel : PageModel
{
    #region Instancefields
    private IEventRepository _eventRepository;
    #endregion

    #region Properties
    [BindProperty]
    public Event Event { get; set; }
    #endregion

    #region Constructors
    public EditEventModel(IEventRepository eventRepository)
    {
        _eventRepository = eventRepository;
    }
    #endregion

    #region Methods
    public IActionResult OnGet(int id)
    {
        Event = _eventRepository.GetEvent(id);
        if (Event == null)
            return RedirectToPage("/NotFound");

        return Page();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        _eventRepository.UpdateEvent(Event);
        return RedirectToPage("GetAllEvents");
    }
    #endregion
}
