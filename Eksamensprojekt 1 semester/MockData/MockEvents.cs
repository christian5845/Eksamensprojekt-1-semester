using Eksamensprojekt_1_semester.Models;

namespace Eksamensprojekt_1_semester.MockData
{
    public static class MockEvents
    {
        private static List<Event> _events = new List<Event>
        {
            new Event(1, "Intro Kursus", "Kursus/Undervisning", 200.0),
            new Event(2, "Grill og hygge på havnen", "Socialt arrangement", 50.0),
            new Event(3, "Kapsejllads", "Konkurrence", 50.0)
        };
        public static List<Event> GetMockEvents()
        {
            return _events;
        }

        public static void AddEvent(Event e)
        {
            _events.Add(e);
        }
        
    }
}
