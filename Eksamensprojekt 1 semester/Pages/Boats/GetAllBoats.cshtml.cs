using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Eksamensprojekt_1_semester.MockData;
using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;

namespace Eksamensprojekt_1_semester.Pages.Boats
{
    public class GetAllBoatsModel : PageModel
    {
        // Dependency injection af BoatRepository.
        private IBoatRepository _boatRepository;

        // Constructor til at initialisere BoatRepository.
        public GetAllBoatsModel(IBoatRepository boatRepository)
        {
            _boatRepository = boatRepository;
        }

        // Liste over både.
        public List<Boat> Boats { get; private set; }

        // Properties til søgning og filtrering.
        [BindProperty]
        public string SearchType { get; set; }
        
        [BindProperty]
        public double MinPrice { get; set; }
        
        [BindProperty]
        public double MaxPrice { get; set; }

        // Hent alle både ved GET-anmodning.
        public void OnGet()
        {
            Boats = _boatRepository.GetBoats();
        }

        // Søg både efter type ved POST-anmodning.
        public IActionResult OnPostTypeSearch()
        {
            Boats = _boatRepository.GetBoatByType(SearchType).ToList();
            return Page();
        }

        // Filtrer både efter pris ved POST-anmodning.
        public IActionResult OnPostPriceFilter()
        {
            Boats = _boatRepository.PriceFilter(MaxPrice, MinPrice).ToList();
            return Page();
        }
    }
}
