using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.BoatDescriptions
{
    public class EditBoatDescriptionsModel : PageModel
    {
        private IBoatRepository _iBoatRepository;
        [BindProperty]
        public BoatDescription BoatDescription { get; set; }

        public EditBoatDescriptionsModel(IBoatRepository iBoatRepository)
        {
            _iBoatRepository = iBoatRepository;
        }

        public void OnGet()
        {
        }
    }
}
