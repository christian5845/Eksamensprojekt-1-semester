using System.Text;

namespace Eksamensprojekt_1_semester.Models;

public class Boat 
{
    public int Id { get; set; }
    public string Type { get; set; }
    public string Size { get; set; }
    public double PricePerDay { get; set; }

    public Boat() { }

public Boat(int id, string type, string size, double pricePerDay)
    {
        Id = id;
        Type = type;
        Size = size;
        PricePerDay = pricePerDay;
    }
}
