using Eksamensprojekt_1_semester.Models;
using System.Text.Json;

namespace Eksamensprojekt_1_semester.Services.Json;

public class JsonFileIDLogService
{
    public IWebHostEnvironment WebHostEnvironment { get; }

    public JsonFileIDLogService(IWebHostEnvironment webHostEnvironment)
    {
        WebHostEnvironment = webHostEnvironment;
    }

    private string JsonFileName
    {
        get
        {
            return Path.Combine(WebHostEnvironment.WebRootPath,
                "Data", "IDFile.json");
        }
    }

    public IEnumerable<IDLog> GetJsonIDLog()
    {
        using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
        {
            return JsonSerializer.Deserialize<IDLog[]>(
                jsonFileReader.ReadToEnd());
        }
    }

    public void SaveJsonIDLog(List<IDLog> iDs)
    {
        using (FileStream jsonFileWriter = File.Create(JsonFileName))
        {
            Utf8JsonWriter jsonWriter = new Utf8JsonWriter(
                jsonFileWriter,
                new JsonWriterOptions
                {
                    SkipValidation = false,
                    Indented = true
                });

            JsonSerializer.Serialize<IDLog[]>(
                jsonWriter,
                iDs.ToArray());
        }
    }
}
