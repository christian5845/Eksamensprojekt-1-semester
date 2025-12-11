using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;


namespace Eksamensprojekt_1_semester.Pages.BoatMaintenance
{
    public class MaintenanceLogModel : PageModel
    {
        private IMaintenanceRepository _maintenanceRepository;

        public MaintenanceLogModel(IMaintenanceRepository maintenanceRepository)
        {
            _maintenanceRepository = maintenanceRepository;
        }

        public List<MaintenanceLog> MaintenanceLogs { get; private set; }
        
        public void OnGet()
        {
            MaintenanceLogs = _maintenanceRepository.GetMaintenanceLogs();
        }
    }
}
