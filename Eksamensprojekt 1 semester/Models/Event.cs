namespace Eksamensprojekt_1_semester.Models;

public class Event
{
    #region properties
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public double Price { get; set; }
    public DateTime DateStart { get; set; }
    public DateTime DateEnd { get; set; }
    #endregion

    #region constructors
    public Event() { }
    public Event(int id, string name, string type, double price, DateTime dateStart, DateTime dateEnd)
    {
        Id = id;
        Name = name;
        Type = type;
        Price = price;
        DateStart = dateStart;
        DateEnd = dateEnd;
    }
    #endregion
}
