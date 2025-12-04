namespace Eksamensprojekt_1_semester.MockData;

public class TestBåd
{
    public string Navn { get; set; }
    public double Længde { get; set; }
    public double Bredde { get; set; }
    public string Beskrivelse { get; set; }

    public TestBåd(string navn, double længde, double bredde, string beskrivelse)
    {
        Navn = navn;
        Længde = længde;
        Bredde = bredde;
        Beskrivelse = beskrivelse;
    }

 


}
