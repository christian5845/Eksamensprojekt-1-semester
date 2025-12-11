namespace Eksamensprojekt_1_semester.Models
{
    public class EventParticipant
    {
        public int EventId { get; set; }
        public int MemberId { get; set; }

        public EventParticipant() { }

        public EventParticipant(int eventId, int memberId)
        {
            EventId = eventId;
            MemberId = memberId;
        }
    }
}

