using Microsoft.AspNetCore.Mvc;
using UnitTest_Exercise.BusinessLogicLayer;

namespace UnitTest_Exercise.DataAccessLayer.Repository.Interrfaces
{
    public interface ITimeRepository
    {
         DateTime GetConvertTimeZone(InputTimeZoneModel inDate);
         bool IsDaylightSavingTime(DateTime date);
         TimeSpan GetDiferenceTime (InputTimeZoneModel date);
        bool isCorrectDate(DateTime date);
    }
}
