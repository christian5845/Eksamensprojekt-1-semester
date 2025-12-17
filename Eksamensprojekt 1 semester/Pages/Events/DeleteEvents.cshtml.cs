using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.Events
{
    public class DeleteEventsModel : PageModel
    {
        private IEventRepository _eventRepository;

        public DeleteEventsModel(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        [BindProperty]
        public Event Event { get; set; }
        public IActionResult OnGet(int id)
        {
            Event = _eventRepository.GetEvent(id);
            if (Event == null)
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

            return Page();
        }

        public IActionResult OnPost()
        {
            Event deletedEvent = _eventRepository.DeleteEvent(Event.Id);
            if (deletedEvent == null)
                return RedirectToPage("/NotFound"); // Event findes ikke

            return RedirectToPage("GetAllEvents"); // Slettet succesfuldt
        }
    }
}
