using Eksamensprojekt_1_semester.Models;
using System.Text.Json;

namespace Eksamensprojekt_1_semester.Services.Json
{
    public class JsonFileBoatService
    {
        public IWebHostEnvironment WebHostEnvironment { get; }

        //Dependency Injection
        public JsonFileBoatService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Boats.json"); }
        }

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

        public IEnumerable<Boat> GetJsonBoats()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Boat[]>(jsonFileReader.ReadToEnd());
            }
        }
    }

}
