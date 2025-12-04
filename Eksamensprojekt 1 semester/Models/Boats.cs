using System.Text;

namespace Eksamensprojekt_1_semester.Models
{
    public class Boats 
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }

        public Boats() { }
    
    public Boats(int id, string type, string size)
        {
            Id = id;
            Type = type;
            Size = size;
        }
    }
}
