using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Services.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.BoatDescriptions
{
    public class EditBoatDescriptionsModel : PageModel
    {
        private IBoatDescriptionRepository _iBoatDescriptionRepository;
        [BindProperty]
        public BoatDescription BoatDescription { get; set; }
        [BindProperty]
        public Boat Boat { get; set; }
        private List<string> _types;


        public EditBoatDescriptionsModel(IBoatDescriptionRepository iBoatDescriptionRepository)
        {
            _iBoatDescriptionRepository = iBoatDescriptionRepository;
            _types = new List<string>();
        }

        public IActionResult OnGet(int id)
        {
            Boat = _iBoatDescriptionRepository.GetBoat(id);
            List<BoatDescription> descriptions = _iBoatDescriptionRepository.GetBoatDescriptions();
            BoatDescription = new BoatDescription(Boat.Type);
            foreach(var type in descriptions)
            {
                _types.Add(type.Type);
            }

            if(!_types.Contains(Boat.Type))
            {
                _iBoatDescriptionRepository.AddBoatDescription(Boat.Type);
            }

            if (Boat == null)
                return RedirectToPage("/NotFound");
            else
                return Page();
        }

        public IActionResult OnPost()
        {
            //if(!ModelState.IsValid)
            //{
            //    return Page();
            //}
            _iBoatDescriptionRepository.EditBoatDescription(BoatDescription);
            return RedirectToPage("GetAllBoatDescriptions");
        }
    }
}
