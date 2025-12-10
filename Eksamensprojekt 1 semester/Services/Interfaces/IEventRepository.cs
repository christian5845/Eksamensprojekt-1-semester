using Eksamensprojekt_1_semester.Models;

namespace Eksamensprojekt_1_semester.Services.Interfaces
{
    public interface IEventRepository
    {
        void AddEvent(Event e);
        void UpdateEvent(Event e);
        IEnumerable<Event> NameSearch(string str);
        List<Event> GetEvents();
        Event DeleteEvent(int id);
        Event GetEvent(int id);
    }
}
