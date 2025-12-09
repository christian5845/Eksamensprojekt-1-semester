namespace Eksamensprojekt_1_semester.Services.Interfaces;

public interface IIDLogRepository
{
    int GetBoatID();
    void ReturnUpdatedBoatID();
    int GetMemberID();
    void ReturnUpdatedMemberID();
    int GetBookingID();
    void ReturnUpdatedBookingID();

}
