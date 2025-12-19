using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.BoatMaintenance;
//Jonas
public class DeleteLogModel : PageModel
{
    #region Instancefields
    private IMaintenanceRepository _maintenanceRepository;

    public DeleteLogModel(IMaintenanceRepository maintenanceRepository)
    {
        _maintenanceRepository = maintenanceRepository;
    }
    #endregion

    #region Properties
    [BindProperty]
    public MaintenanceLog MaintenanceLog { get; set; }
    #endregion

    #region Methods
    public IActionResult OnGet(int id)

    {
        MaintenanceLog = _maintenanceRepository.GetMaintenanceLog(id);
        if (MaintenanceLog == null)
            return RedirectToPage("/NotFound");

        return Page();
    }

    public IActionResult OnPost(int id)
    {
        MaintenanceLog deletedLog = _maintenanceRepository.DeleteMaintenanceLog(MaintenanceLog.LogId);
        if (deletedLog == null)
            return RedirectToPage("/NotFound");

        return RedirectToPage("MaintenanceLog");
    }
    #endregion
}
