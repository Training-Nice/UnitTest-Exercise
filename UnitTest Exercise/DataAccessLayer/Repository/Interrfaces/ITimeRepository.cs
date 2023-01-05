using Microsoft.AspNetCore.Mvc;
using UnitTest_Exercise.BusinessLogicLayer;

namespace UnitTest_Exercise.DataAccessLayer.Repository.Interrfaces
{
    public interface ITimeRepository
    {
        DateTime getConvertTimeZone(InputTimeZoneModel inDate);
        bool isDaylightSavingTime(DateTime date);
        TimeSpan getDiferenceTime (InputTimeZoneModel date);


    }
}
