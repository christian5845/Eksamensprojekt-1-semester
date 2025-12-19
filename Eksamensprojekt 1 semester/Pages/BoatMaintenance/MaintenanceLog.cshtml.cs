using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;


namespace Eksamensprojekt_1_semester.Pages.BoatMaintenance;

public class MaintenanceLogModel : PageModel
{
    #region Instancefields
    private IMaintenanceRepository _maintenanceRepository;
    #endregion

    #region Properties
    public List<MaintenanceLog> MaintenanceLogs { get; private set; }
    #endregion

    #region Constructors
    public MaintenanceLogModel(IMaintenanceRepository maintenanceRepository)
    {
        _maintenanceRepository = maintenanceRepository;
    }
    #endregion

    #region Methods
    public void OnGet()
    {
        MaintenanceLogs = _maintenanceRepository.GetMaintenanceLogs();
    }
    #endregion
}
