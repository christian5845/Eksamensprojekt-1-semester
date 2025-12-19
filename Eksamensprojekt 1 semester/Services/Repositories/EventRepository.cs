using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.MockData;


namespace Eksamensprojekt_1_semester.Services.Repositories;
//Søren
public class EventRepository : IEventRepository
{
    #region Instancefields
    private List<Event> _events;
    #endregion

    #region Constructors
    public EventRepository()
    {
        _events = MockEvents.GetMockEvents();
    }
    #endregion

    #region Methods
    public List<Event> GetEvents()
    {
        return _events;
    }

    public void AddEvent(Event e)
    {
        e.Id = _events.Count + 1;
        _events.Add(e);
    }

        public IEnumerable<Event> NameSearch(string str)
    {
        List<Event> nameSearch = new List<Event>();
        foreach (Event e in _events)
            {
            if (string.IsNullOrEmpty(str) || 
            e.Name.ToLower().Contains(str.ToLower()))
                {
                nameSearch.Add(e);
            }
        }
        return nameSearch;
    }

    public void UpdateEvent(Event e)
    {
        if (e != null)
        {
            foreach (Event ev in _events)
            {
                if (e.Id == ev.Id)
                {
                    ev.Name = e.Name;
                    ev.Type = e.Type;
                    ev.Price = e.Price;
                    return;
                }
            }
        }
    }

    public Event GetEvent(int id)
    {
        foreach (Event evt in _events)
        {
            if (evt.Id == id)
                return evt;
        }
        return null;
    }
        
    
    public Event DeleteEvent(int id)
    {
        foreach (Event e in _events)
        {
            if (e.Id == id)
            {
                _events.Remove(e);
                return e;
            }
        }
        return null;
    }
    #endregion
}
