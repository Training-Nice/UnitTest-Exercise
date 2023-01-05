using Microsoft.AspNetCore.Mvc;
using NodaTime;
using TimeZoneConverter;
using UnitTest_Exercise.BusinessLogicLayer;

namespace UnitTest_Exercise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeZoneController : Controller
    {
        [HttpPost]
        [Route("getConvertDate")]
        public async Task<IActionResult> getConvertTimeZone([FromBody] InputTimeZoneModel inDate)
        {
            TimeZoneInfo universalZone = TimeZoneInfo.Utc;
            var inputZone = TZConvert.IanaToWindows("America/New_York");
            DateTime inputTime = new DateTime(2023, 01, 04, 20, 49, 00);



            TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById(inputZone);

            DateTime aux = TimeZoneInfo.ConvertTimeToUtc(inputTime, easternZone);


            var result = new {
              a= universalZone.DisplayName,
              b= universalZone.StandardName,
              inputZone,
              hourInput= inputTime.TimeOfDay,
              c=universalZone.DaylightName,
              aux,
              hourOutput = aux.TimeOfDay

            };
            try
            {

              

                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
