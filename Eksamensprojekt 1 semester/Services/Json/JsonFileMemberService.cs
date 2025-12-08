using System.Text.Json;
using Eksamensprojekt_1_semester.Models;

namespace Eksamensprojekt_1_semester.Services.Json
{
    public class JsonFileMemberService
    {
        public IWebHostEnvironment WebHostEnvironment { get; }

        public JsonFileMemberService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        private string JsonFileName
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath,
                    "Data", "Members.json");
            }
        }

        public IEnumerable<Member> GetJsonMembers()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Member[]>(
                    jsonFileReader.ReadToEnd());
            }
        }

        public void SaveJsonMembers(List<Member> members)
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

                JsonSerializer.Serialize<Member[]>(
                    jsonWriter,
                    members.ToArray());
            }
        }
    }
}
