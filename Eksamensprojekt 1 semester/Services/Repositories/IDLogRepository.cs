using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Services.Json;

namespace Eksamensprojekt_1_semester.Services.Repositories
{
    public class IDLogRepository : IIDLogRepository
    {
        #region Instancefields
        private List<IDLog> _iDLog;
        private JsonFileIDLogService _jsonFileIDLogService;
        #endregion

        #region Constructor
        public IDLogRepository(JsonFileIDLogService jsonFileIDLogService)
        {
            _jsonFileIDLogService = jsonFileIDLogService;
            _iDLog = _jsonFileIDLogService.GetJsonIDLog().ToList();
        }
        #endregion

        #region Methods
        public int GetNewBoatID()
        {
            foreach(IDLog iDLog in _iDLog)
            {
                iDLog.BoatID++;
                _jsonFileIDLogService.SaveJsonIDLog(_iDLog);
                return iDLog.BoatID;
            }
            return 0;
        }

        public int GetNewBookingID()
        {
            foreach (IDLog iDLog in _iDLog)
            {
                iDLog.BookingID++;
                return iDLog.BookingID;
            }
            return 0;
        }

        public int GetNewMemberID()
        {
            foreach (IDLog iDLog in _iDLog)
            {
                iDLog.MemberID++;
                _jsonFileIDLogService.SaveJsonIDLog(_iDLog);
                return iDLog.MemberID;
            }
            return 0;
        }

        public int GetNewLogID()
        {
            foreach (IDLog iDLog in _iDLog)
            {
                iDLog.LogID++;
                _jsonFileIDLogService.SaveJsonIDLog(_iDLog);
                return iDLog.LogID;
            }
            return 0;
        }
        #endregion
    }
}
