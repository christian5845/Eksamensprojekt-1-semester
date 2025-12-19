using Eksamensprojekt_1_semester.Models;
using System.Text.Json;

namespace Eksamensprojekt_1_semester.Services.Json;
//Rasmus
public class JsonFileBoatDescriptionService
{
    
    public IWebHostEnvironment WebHostEnvironment { get; }
  

    
    //Dependency Injection
    public JsonFileBoatDescriptionService(IWebHostEnvironment webHostEnvironment)
    {
        WebHostEnvironment = webHostEnvironment;
    }
    

  
    private string JsonFileName
    {
        get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "BoatDescriptions.json"); }
    }
   

   
    public void SaveJsonBoatDescriptions(List<BoatDescription> boatDescriptions)
    {
        using (FileStream jsonFileWriter = File.Create(JsonFileName))
        {
            Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
            {
                SkipValidation = false,
                Indented = true
            });
            JsonSerializer.Serialize<BoatDescription[]>(jsonWriter, boatDescriptions.ToArray());
        }
    }

    public IEnumerable<BoatDescription> GetJsonBoatDescriptions()
    {
        using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
        {
            return JsonSerializer.Deserialize<BoatDescription[]>(jsonFileReader.ReadToEnd());
        }
    }
    
}
