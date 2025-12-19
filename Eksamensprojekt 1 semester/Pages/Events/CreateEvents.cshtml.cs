using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.Events;

public class CreateEventsModel : PageModel
{
    #region Instancefields
    private IEventRepository _eventRepository;
    #endregion 

    #region Properties
    [BindProperty]
    public Event Event { get; set; }
    #endregion

    #region Constructors
    public CreateEventsModel(IEventRepository eventRepository)
    {
        _eventRepository = eventRepository;
    }
    #endregion

    #region Methods
    public IActionResult OnGet()
    {
        return Page();
    }
    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        _eventRepository.AddEvent(Event);
        return RedirectToPage("GetAllEvents");
    }
    #endregion
}



