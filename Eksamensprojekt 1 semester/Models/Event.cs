namespace Eksamensprojekt_1_semester.Models
{
    public class Event
    {
        #region properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        #endregion

        #region constructors
        public Event() { }
        public Event(int id, string name, string type, double price)
        {
            Id = id;
            Name = name;
            Type = type;
            Price = price;
        }
        #endregion
    }
}
