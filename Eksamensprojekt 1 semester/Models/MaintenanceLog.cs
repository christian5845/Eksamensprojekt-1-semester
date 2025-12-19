using System.ComponentModel.DataAnnotations;

namespace Eksamensprojekt_1_semester.Models;

public class MaintenanceLog
{
    #region Properties
    public int? LogId { get; set; }

    [Display(Name = "Bådtype")]
    [Required(ErrorMessage = "Der skal angives en bådtype")]
    public string? Type { get; set; }

    [Display(Name = "Antal Reparationer")]
    [Required(ErrorMessage = "Der skal angives et antal reparationer")]
    public int? RepairCount { get; set; } = 0;

    [Display(Name = "Senest vedligeholdt/synet")]
    [Required(ErrorMessage = "Der skal angives en dato")]
    public DateOnly? LastServiced { get; set; }

    [Display(Name = "Alder")]
    [Required(ErrorMessage = "Der skal angives en alder")]
    public int? Age { get; set; }
    #endregion

    #region Constructors
    public MaintenanceLog() { }

    public MaintenanceLog(string type, int repairCount, int age, DateOnly lastServiced)
    {
        Type = type;
        RepairCount = repairCount;
        Age = age;
        LastServiced = lastServiced;
    }
    #endregion
}
