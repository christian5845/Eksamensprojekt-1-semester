using Eksamensprojekt_1_semester.Models;
using System.Text.Json;

namespace Eksamensprojekt_1_semester.Services.Json;
//Rasmus
public class JsonFileBookingService
{
    public IWebHostEnvironment WebHostEnvironment { get; }

    //Dependency Injection
    public JsonFileBookingService(IWebHostEnvironment webHostEnvironment)
    {
        WebHostEnvironment = webHostEnvironment;
    }

    private string JsonFileName
    {
        get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Bookings.json"); }
    }

    public void SaveJsonBookings(List<Booking> bookings)
    {
        using (FileStream jsonFileWriter = File.Create(JsonFileName))
        {
            Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
            {
                SkipValidation = false,
                Indented = true
            });
            JsonSerializer.Serialize<Booking[]>(jsonWriter, bookings.ToArray());
        }
    }

    public IEnumerable<Booking> GetJsonBookings()
    {
        using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
        {
            return JsonSerializer.Deserialize<Booking[]>(jsonFileReader.ReadToEnd());
        }
    }
}
