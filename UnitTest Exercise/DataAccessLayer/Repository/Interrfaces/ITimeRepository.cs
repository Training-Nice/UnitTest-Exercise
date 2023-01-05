using Microsoft.AspNetCore.Mvc;
using UnitTest_Exercise.BusinessLogicLayer;

namespace UnitTest_Exercise.DataAccessLayer.Repository.Interrfaces
{
    public interface ITimeRepository
    {
        Task<DateTime> getConvertTimeZone(InputTimeZoneModel inDate);
    }
}
