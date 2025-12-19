using Eksamensprojekt_1_semester.Models;

namespace Eksamensprojekt_1_semester.Services.Interfaces;
//Jonas
public interface IMaintenanceRepository
{
    List<MaintenanceLog> GetMaintenanceLogs();
    void AddMaintenanceLog(MaintenanceLog log);
    void UpdateMaintenanceLog(MaintenanceLog log);
    MaintenanceLog GetMaintenanceLog(int id);
    MaintenanceLog DeleteMaintenanceLog(int? logId);
}
