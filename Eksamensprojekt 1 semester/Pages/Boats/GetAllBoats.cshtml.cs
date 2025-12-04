using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Eksamensprojekt_1_semester.MockData;
using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;

namespace Eksamensprojekt_1_semester.Pages.Boats
{
    public class GetAllBoatsModel : PageModel
    {
        private IBoatRepository _boatRepository;
        public GetAllBoatsModel(IBoatRepository boatRepository)
        {
            _boatRepository = boatRepository;
        }
        public List<Boat> Boats { get; private set; }
        public void OnGet()
        {
            Boats = _boatRepository.GetBoats();
        }
    }
}
