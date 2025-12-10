using Eksamensprojekt_1_semester.Models;
using System.Text.Json;

namespace Eksamensprojekt_1_semester.Services.Json
{
    public class JsonFileMaintenanceLogService
    {
        public IWebHostEnvironment WebHostEnvironment { get; }

        //Dependency Injection
        public JsonFileMaintenanceLogService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "MaintenanceLogs.json"); }
        }

        public void SaveJsonMaintenanceLogs(List<MaintenanceLog> logs)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileName))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<MaintenanceLog[]>(jsonWriter, logs.ToArray());
            }
        }

        public IEnumerable<MaintenanceLog> GetJsonMaintenanceLogs()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<MaintenanceLog[]>(jsonFileReader.ReadToEnd());
            }
        }

    }
}
