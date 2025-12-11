namespace Eksamensprojekt_1_semester.Models;

public class BoatDescription
{
    #region Properties
    public string Type { get; set; }
    public string Description { get; set; }
    #endregion

    #region Constructors
    public BoatDescription()
    {
    }

    public BoatDescription(string type)
    {
        Type = type;
        Description = "Mangler beskrivelse";
    }

    public BoatDescription(string type, string description)
    {
        Type = type;
        Description = description;
    }
    #endregion
}
