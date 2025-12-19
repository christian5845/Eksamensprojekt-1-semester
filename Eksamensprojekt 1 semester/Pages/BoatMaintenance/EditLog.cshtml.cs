using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.BoatMaintenance;
//Jonas
public class EditLogModel : PageModel
{
    #region Instancefields
    private IMaintenanceRepository _maintenanceRepository;
    #endregion

    #region Properties
    [BindProperty]
    public MaintenanceLog MaintenanceLog { get; set; }
    #endregion

    #region Constructor
    public EditLogModel(IMaintenanceRepository maintenanceRepository)
    {
        _maintenanceRepository = maintenanceRepository;
    }
    #endregion

    #region Methods
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
    #endregion
}
