using UnitTest_Exercise.BusinessLogicLayer;
using UnitTest_Exercise.DataAccessLayer.Repository.Interrfaces;

namespace UnitTest_Exercise.DataAccessLayer.Repository
{
    public class TimeRepository : ITimeRepository
    {
        public DateTime getConvertTimeZone(InputTimeZoneModel inDate)
        {
            TimeZone time2 = TimeZone.CurrentTimeZone;
            DateTime test = time2.ToUniversalTime(inDate.Datatime);
            var destinationTime = TimeZoneInfo.FindSystemTimeZoneById(inDate.DestinationTimeZone);
            var outputTime = TimeZoneInfo.ConvertTimeFromUtc(test, destinationTime);
            return outputTime;
        }


        public bool isDaylightSavingTime(DateTime date)
        {
            return date.Month > 6 && date.Month < 9 ? true : false;
        }


        public TimeSpan getDiferenceTime(InputTimeZoneModel date)
        {
            DateTime newTime = getConvertTimeZone(date);
            return date.Datatime.Subtract(newTime);
        }


    }
}
