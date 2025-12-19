using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.Events;
//Troels
public class EventParticipantsOverviewModel : PageModel
{
    #region Instancefields
    // Repository til events
    private readonly IEventRepository _eventRepository;

    // Repository til deltagere
    private readonly IEventParticipationRepository _participationRepository;
    #endregion

    #region Properties
    // Liste over alle events
    public List<Event> Events { get; set; }
    #endregion

    #region Constructors
    public EventParticipantsOverviewModel(IEventRepository eventRepository,IEventParticipationRepository participationRepository)
    {
        _eventRepository = eventRepository;
        _participationRepository = participationRepository;
    }
    #endregion

    #region Methods
    public void OnGet()
    {
        // Hent alle events
        Events = _eventRepository.GetEvents();
    }

    // Metode til at hente alle deltagere for et event
    public List<Member> GetParticipants(int eventId)
    {
        return _participationRepository.GetParticipants(eventId);
    }
    #endregion
}
