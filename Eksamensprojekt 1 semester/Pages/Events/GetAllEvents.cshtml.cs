using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Eksamensprojekt_1_semester.MockData;
using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;

namespace Eksamensprojekt_1_semester.Pages.Events;

public class GetAllEventsModel : PageModel
{
    #region Instancefields
    private IEventRepository _eventRepository;
    #endregion

    #region Properties
    public List<Event> Events { get; set; }

    [BindProperty]
    public string SearchString { get; set; }
    #endregion

    #region Constructors
    public GetAllEventsModel(IEventRepository eventRepository)
    {
        _eventRepository = eventRepository;                   
    }
    #endregion

    #region Methods
    public IActionResult OnPostNameSearch()
    {
        Events = _eventRepository.NameSearch(SearchString).ToList();
        return Page();
    }

    public void OnGet()
    {
        Events = _eventRepository.GetEvents();
    }
    #endregion
}

