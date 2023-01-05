using UnitTest_Exercise.BusinessLogicLayer;
using UnitTest_Exercise.DataAccessLayer.Repository.Interrfaces;

namespace UnitTest_Exercise.DataAccessLayer.Repository
{
    public class TimeRepository : ITimeRepository
    {
        public Task<DateTime> getConvertTimeZone(InputTimeZoneModel inDate)
        {
            throw new NotImplementedException();
        }
    }
}
