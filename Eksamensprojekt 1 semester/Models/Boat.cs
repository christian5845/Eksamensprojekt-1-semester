using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Eksamensprojekt_1_semester.Models;

public class Boat 
{
    private static int _globalBoatID;
    [Display(Name = "Båd ID")]
    [Required(ErrorMessage = "Der skal angives et ID")]
    public int? Id { get; set; }
    [Display(Name = "Båd Type")]
    [Required(ErrorMessage = "Der skal angives en bådtype")]
    public string? Type { get; set; }
    [Display(Name = "Båd Størrelse")]
    [Required(ErrorMessage = "Der skal angives en bådstørrelse")]
    public string? Size { get; set; }
    [Display(Name = "Pris per dag")]
    [Required(ErrorMessage = "Der skal angives en pris per dag")]
    public double? PricePerDay { get; set; }

    public Boat() { }

public Boat(string type, string size, double pricePerDay)
    {
        Id = ++_globalBoatID;
        Type = type;
        Size = size;
        PricePerDay = pricePerDay;
    }
}
