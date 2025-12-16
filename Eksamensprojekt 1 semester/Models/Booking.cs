namespace Eksamensprojekt_1_semester.Models
{
    public class Booking
    {
        #region Properties
        public int BookingId { get; set; }
        public Member? TheBookingMember { get; set; }
        public DateOnly DateStart { get; set; }
        public DateOnly DateEnd { get; set; }
        public string Destination { get; set; }
        public bool AnkommetHjem { get; set; }
        public double Price { get; set; }
        public Boat BookedBoat { get; set; }
        public double TotalPris
        {
            get
            {
                int antalDage = (DateEnd.DayNumber - DateStart.DayNumber) + 1;
                return antalDage * (BookedBoat?.PricePerDay ?? 0);
            }
        }
        #endregion
        #region constructors
        public Booking() { }

        public Booking(Member member, DateOnly datestart, DateOnly dateend, string destination, Boat bookedboat)
        {
            TheBookingMember = member;
            BookedBoat = bookedboat;
            DateStart = datestart;
            DateEnd = dateend;
            Destination = destination;
            AnkommetHjem = false;
        }
        #endregion
    }
}
