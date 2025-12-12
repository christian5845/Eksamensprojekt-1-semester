using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.BoatMaintenance
{
    public class EditLogModel : PageModel
    {
        private IMaintenanceRepository _maintenanceRepository;

        [BindProperty]
        public MaintenanceLog MaintenanceLog { get; set; }

        public EditLogModel(IMaintenanceRepository maintenanceRepository)
        {
            _maintenanceRepository = maintenanceRepository;
        }

        public IActionResult OnGet(int id)
        {
            MaintenanceLog = _maintenanceRepository.GetMaintenanceLog(id);
            if (MaintenanceLog == null)
                return RedirectToPage("/NotFound");

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _maintenanceRepository.UpdateMaintenanceLog(MaintenanceLog);
            return RedirectToPage("MaintenanceLog");
        }
    }
}
