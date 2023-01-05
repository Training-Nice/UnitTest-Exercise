using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NodaTime;
using TimeZoneConverter;
using UnitTest_Exercise.BusinessLogicLayer;
using UnitTest_Exercise.DataAccessLayer.Repository;
using UnitTest_Exercise.DataAccessLayer.Repository.Interrfaces;

namespace UnitTest_Exercise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeZoneController : Controller
    {
        private readonly ITimeRepository _timeRepository;
        public IConfiguration _configuration { get; set; }

        public TimeZoneController(ITimeRepository timeRepository, IConfiguration configuration)
        {
            _timeRepository = timeRepository;
 
            _configuration = configuration;
        }
        [HttpPost]
        [Route("getConvertDate")]
        public IActionResult getConvertTimeZone([FromBody] InputTimeZoneModel inDate)
        {
            try
            {
                var result = new { 
                    ok="ok",
                    result= _timeRepository.getConvertTimeZone(inDate).TimeOfDay
                };
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        [HttpPost]
        [Route("getOriginDaylightSavingTime")]
        public IActionResult getOriginisDaylightSavingTime([FromBody] InputTimeZoneModel inDate)
        {
            try
            {
                var result = new
                {
                    ok = "ok",
                    result = _timeRepository.isDaylightSavingTime(inDate.Datatime) ? "It's daylight saving time" : "It is not daylight saving time"
                };
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        [HttpPost]
        [Route("getDestinationDaylightSavingTime")]
        public IActionResult getDestinationDaylightSavingTime([FromBody] InputTimeZoneModel inDate)
        {
            DateTime newDate = _timeRepository.getConvertTimeZone(inDate);
            try
            {
                var result = new
                {
                    ok = "ok",
                    result = _timeRepository.isDaylightSavingTime(newDate) ? "It's daylight saving time" : "It is not daylight saving time"
                };
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        [HttpPost]
        [Route("getDiferenceTime")]
        public IActionResult getDiferenceTime([FromBody] InputTimeZoneModel inDate)
        {
            try
            {
                var result = new
                {
                    ok = "ok",
                    result = _timeRepository.getDiferenceTime(inDate)
                };
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        [HttpPost]
        [Route("getDiferentFormatDate")]
        public IActionResult getDiferentFormatDate([FromBody] InputTimeZoneModel inDate)
        {
            try
            {
                var result = new
                {
                    ok = "ok",
                    result = _timeRepository.getConvertTimeZone(inDate)
                };
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        [HttpPost]
        [Route("getDiferentFormatTime")]
        public IActionResult getDiferentFormatTime([FromBody] InputTimeZoneModel inDate)
        {
            try
            {
                var result = new
                {
                    ok = "ok",
                    result = _timeRepository.getConvertTimeZone(inDate).TimeOfDay
                };
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
