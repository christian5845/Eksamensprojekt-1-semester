using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.Events
{
    public class EditEventModel : PageModel
    {
        private IEventRepository _eventRepository;

        [BindProperty]
        public Event Event { get; set; }

        public EditEventModel(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

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
    }
}
