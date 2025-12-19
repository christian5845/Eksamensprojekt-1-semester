namespace Eksamensprojekt_1_semester.Models;

public class EventParticipant
{
    #region properties
    public int EventId { get; set; }
    public int MemberId { get; set; }
    #endregion

    #region constructors
    public EventParticipant() { }

    public EventParticipant(int eventId, int memberId)
    {
        EventId = eventId;
        MemberId = memberId;
    }
}
#endregion

