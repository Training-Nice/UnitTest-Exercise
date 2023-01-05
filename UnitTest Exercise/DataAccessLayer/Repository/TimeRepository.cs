using UnitTest_Exercise.BusinessLogicLayer;
using UnitTest_Exercise.DataAccessLayer.Repository.Interrfaces;

namespace UnitTest_Exercise.DataAccessLayer.Repository
{
    public class TimeRepository : ITimeRepository
    {
        public DateTime GetConvertTimeZone(InputTimeZoneModel inDate)
        {
            try
            {
                TimeZone time2 = TimeZone.CurrentTimeZone;
                DateTime test = time2.ToUniversalTime(inDate.Datatime);
                var destinationTime = TimeZoneInfo.FindSystemTimeZoneById(inDate.DestinationTimeZone);
                var outputTime = TimeZoneInfo.ConvertTimeFromUtc(test, destinationTime);
                return outputTime;
            }
            catch (Exception)
            {
                return new DateTime(1,1,1,0,0,0);
            }

        }


        public bool IsDaylightSavingTime(DateTime date)
        {
            return date.Month > 6 && date.Month < 9 ? true : false;
        }


        public TimeSpan GetDiferenceTime(InputTimeZoneModel date)
        {
            DateTime newTime = GetConvertTimeZone(date);
            return date.Datatime.Subtract(newTime);
        }

        public bool isCorrectDate(DateTime date)
        {
            return date.Year!=1;
        }
    }
}
