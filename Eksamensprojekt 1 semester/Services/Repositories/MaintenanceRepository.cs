using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Services.Json;

namespace Eksamensprojekt_1_semester.Services.Repositories
{
    public class MaintenanceRepository : IMaintenanceRepository
    {
        private List<MaintenanceLog> _maintenanceLogs;

        private JsonFileMaintenanceLogService JsonFileMaintenanceLogService;
        private IIDLogRepository _iIDLogRepository;


        public MaintenanceRepository(JsonFileMaintenanceLogService jsonFileMaintenanceLogService, IIDLogRepository iIDLogRepository)
        {
            JsonFileMaintenanceLogService = jsonFileMaintenanceLogService;
            _iIDLogRepository = iIDLogRepository;
            _maintenanceLogs = JsonFileMaintenanceLogService.GetJsonMaintenanceLogs().ToList();

        }

        public List<MaintenanceLog> GetMaintenanceLogs()
        {
            return _maintenanceLogs;
        }

        public void AddMaintenanceLog(MaintenanceLog log)
        {
            log.LogId = _iIDLogRepository.GetNewLogID();
            _maintenanceLogs.Add(log);
            JsonFileMaintenanceLogService.SaveJsonMaintenanceLogs(_maintenanceLogs);
        }

        public MaintenanceLog GetMaintenanceLog(int id)
        {
            foreach (MaintenanceLog log in _maintenanceLogs)
            {
                if (log.LogId == id)
                    return log;
            }

            return null;
        }

        public void UpdateMaintenanceLog(MaintenanceLog log)
        {
            if (log != null)
            {
                foreach (MaintenanceLog l in _maintenanceLogs)
                {
                    if (l.LogId == log.LogId)
                    {
                        l.Type = log.Type;
                        l.RepairCount = log.RepairCount;
                        l.Age = log.Age;
                        l.LastServiced = log.LastServiced;
                    }
                }
                JsonFileMaintenanceLogService.SaveJsonMaintenanceLogs(_maintenanceLogs);
            }
        }

        public MaintenanceLog DeleteMaintenanceLog(int? logId)
        {
            MaintenanceLog logToBeDeleted = null;
            foreach (MaintenanceLog log in _maintenanceLogs)
            {
                if (log.LogId == logId)
                {
                    logToBeDeleted = log;
                    break;
                }
            }

            if (logToBeDeleted != null)
            {
                _maintenanceLogs.Remove(logToBeDeleted);
                JsonFileMaintenanceLogService.SaveJsonMaintenanceLogs(_maintenanceLogs);
            }

            return logToBeDeleted;
        }

    }
}
