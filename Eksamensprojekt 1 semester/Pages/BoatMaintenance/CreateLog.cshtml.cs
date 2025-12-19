using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.BoatMaintenance;

public class CreateLogModel : PageModel
{
    #region Instancefields
    private IMaintenanceRepository _maintenanceRepository;
    #endregion

    #region Properties
    [BindProperty]
    public MaintenanceLog MaintenanceLog { get; set; }
    #endregion

    #region Constuctors
    public CreateLogModel (IMaintenanceRepository maintenanceRepository)
    {
        _maintenanceRepository = maintenanceRepository;
    }
    #endregion

    #region Methods
    public IActionResult OnGet()
    {
        return Page();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        _maintenanceRepository.AddMaintenanceLog(MaintenanceLog);
        return RedirectToPage("MaintenanceLog");
    }
    #endregion
}
