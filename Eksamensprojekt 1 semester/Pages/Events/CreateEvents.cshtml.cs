using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.Events
{
    public class CreateEventsModel : PageModel
    {
        private IEventRepository _eventRepository;
        [BindProperty]
        public Event Event { get; set; }
        public CreateEventsModel(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }
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
    }
}



