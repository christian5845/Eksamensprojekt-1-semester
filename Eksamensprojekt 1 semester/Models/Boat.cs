using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Eksamensprojekt_1_semester.Models;
//Jonas
public class Boat 
{
    #region Properties
    public int? Id { get; set; }
    [Display(Name = "Båd Type")]
    [Required(ErrorMessage = "Der skal angives en bådtype")]
    public string? Type { get; set; }
    [Display(Name = "Båd Størrelse")]
    [Required(ErrorMessage = "Der skal angives en bådstørrelse")]
    public string? Size { get; set; }
    [Display(Name = "Pris per dag")]
    [Required(ErrorMessage = "Der skal angives en pris per dag")]
    public double PricePerDay { get; set; }
    #endregion

    #region Constructors
    // Default constructor som creater et tomt Boat objekt (default værdier).
    // Benyttes til Razor Pages og Json-filerne.
    public Boat() { }

    public Boat(string type, string size, double pricePerDay)
    {
        Type = type;
        Size = size;
        PricePerDay = pricePerDay;
    }
    #endregion
}
