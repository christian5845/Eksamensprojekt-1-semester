using Eksamensprojekt_1_semester.Models;

namespace Eksamensprojekt_1_semester.Services.Interfaces;
//Søren
public interface IEventParticipationRepository
{
    void AddParticipant(int eventId, int memberId);
    List<Member> GetParticipants(int eventId);
    bool IsMemberParticipating(int eventId, int memberId);
}
