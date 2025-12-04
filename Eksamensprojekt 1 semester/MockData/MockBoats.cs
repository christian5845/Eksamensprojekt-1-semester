namespace Eksamensprojekt_1_semester.MockData;

public class MockBoats
{
    public string Navn { get; set; }
    public double Længde { get; set; }
    public double Bredde { get; set; }
    public string Beskrivelse { get; set; }
    private static List<MockBoats> Boats = new List<MockBoats> 
    {  new MockBoats("Tera",2.87,1.23,"Tera jollen er en moderne begynder-jolle, som kan sejles af unge fra 8 år og op. Det er en selvlænsende jolle, som ser godt ud, og som sejler godt.\r\n\r\nTera jollen sejler en smule hurtigere end en Optimist-jolle, og man kan træningsmæssigt uden problemer blande de to jolletyper."),
         new MockBoats("Feva",8.5,1,"test"),
         new MockBoats("Anne",8.5,1,"Test2")};


    public MockBoats(string navn, double længde, double bredde, string beskrivelse)
    {
        Navn = navn;
        Længde = længde;
        Bredde = bredde;
        Beskrivelse = beskrivelse;
    }

    public static List<MockBoats> GetMockBoats() { return Boats; }


}
