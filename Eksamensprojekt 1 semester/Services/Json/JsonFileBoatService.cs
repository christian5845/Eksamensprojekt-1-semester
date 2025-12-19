using Eksamensprojekt_1_semester.Models;
using System.Text.Json;

namespace Eksamensprojekt_1_semester.Services.Json;
//Jonas
public class JsonFileBoatService
{
   
    public IWebHostEnvironment WebHostEnvironment { get; }
   

   
    //Dependency Injection
    public JsonFileBoatService(IWebHostEnvironment webHostEnvironment)
    {
        WebHostEnvironment = webHostEnvironment;
    }
   

    // Sti til JSON-filen, der indeholder båddata.
    private string JsonFileName
    {
        get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Boats.json"); }
    }

    // Gemmer en liste af både til JSON-filen.
    public void SaveJsonBoats(List<Boat> boats)
    {
        using (FileStream jsonFileWriter = File.Create(JsonFileName))
        {
            Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
            {
                SkipValidation = false,
                Indented = true
            });
            JsonSerializer.Serialize<Boat[]>(jsonWriter, boats.ToArray());
        }
    }

    // Henter en liste af både fra JSON-filen.
    public IEnumerable<Boat> GetJsonBoats()
    {
        using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
        {
            return JsonSerializer.Deserialize<Boat[]>(jsonFileReader.ReadToEnd());
        }
    }
}
