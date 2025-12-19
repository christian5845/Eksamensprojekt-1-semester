using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;

namespace Eksamensprojekt_1_semester.Services.Repositories;
//Søren
public class EventParticipationRepository : IEventParticipationRepository
{
    #region Instancefields
    private List<EventParticipant> _participants = new List<EventParticipant>();
    private IMemberRepository _memberRepository;
    #endregion

    #region Constructors
    public EventParticipationRepository(IMemberRepository memberRepository)
    {
        _memberRepository = memberRepository;
    }
    #endregion

    #region Methods
    public void AddParticipant(int eventId, int memberId)
    {
        if (!IsMemberParticipating(eventId, memberId))
        {
            _participants.Add(new EventParticipant(eventId, memberId));
        }
    }

    public List<Member> GetParticipants(int eventId)
    {
        // 1. Find MemberIds for det givne event
        List<int> memberIds = new List<int>();
        foreach (var p in _participants)
        {
            if (p.EventId == eventId)
            {
                memberIds.Add(p.MemberId);
            }
        }

        // 2. Find medlemmer, der matcher de fundne MemberIds
        List<Member> participants = new List<Member>();
        foreach (var m in _memberRepository.GetMembers())
        {
            int memberId = m.Id ?? 0; // håndter null
            if (memberIds.Contains(memberId))
            {
                participants.Add(m);
            }
        }
        return participants;
    }

    public bool IsMemberParticipating(int eventId, int memberId)
    {
        // Gå igennem alle deltagelser
        foreach (var p in _participants)
        {
            // Tjek om både EventId og MemberId matcher
            if (p.EventId == eventId && p.MemberId == memberId)
            {
                return true; // Stop straks hvis vi finder et match
            }
        }
        // Hvis ingen match fundet
        return false;
    }
    #endregion
}
