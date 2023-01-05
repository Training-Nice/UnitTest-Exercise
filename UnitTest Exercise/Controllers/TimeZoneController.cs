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

        public TimeZoneController(ITimeRepository timeRepository)
        {
            _timeRepository = timeRepository;
 
        }
        [HttpPost]
        [Route("getConvertDate")]
        public ActionResult getConvertTimeZone([FromBody] InputTimeZoneModel inDate)
        {
            try
            {
                DateTime resultTime = _timeRepository.GetConvertTimeZone(inDate);
                if (resultTime.Year == 1) throw new Exception();
                var result = new { 
                    ok="ok",
                    result= resultTime.TimeOfDay
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
        public ActionResult getOriginisDaylightSavingTime([FromBody] InputTimeZoneModel inDate)
        {
            try
            {
                var result = new
                {
                    ok = "ok",
                    result = _timeRepository.IsDaylightSavingTime(inDate.Datatime) ? "It's daylight saving time" : "It is not daylight saving time"
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
        public ActionResult getDestinationDaylightSavingTime([FromBody] InputTimeZoneModel inDate)
        {
            DateTime newDate = _timeRepository.GetConvertTimeZone(inDate);
            try
            {
                var result = new OutputTimeZoneModel
                {
                    ok = "ok",
                    result = _timeRepository.IsDaylightSavingTime(newDate) ? "It's daylight saving time" : "It is not daylight saving time"
                };
                if (newDate.Year == 1) throw new Exception();
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

        }
        [HttpPost]
        [Route("getDiferenceTime")]
        public ActionResult getDiferenceTime([FromBody] InputTimeZoneModel inDate)
        {
            try
            {
                if (!_timeRepository.isCorrectDate(inDate.Datatime)) throw new Exception();
                var result = new
                {
                    ok = "ok",
                    result = _timeRepository.GetDiferenceTime(inDate)
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
        public ActionResult getDiferentFormatDate([FromBody] InputTimeZoneModel inDate)
        {
            try
            {
                if (!_timeRepository.isCorrectDate(inDate.Datatime)) throw new Exception();
                var result = new
                {
                    ok = "ok",
                    result = _timeRepository.GetConvertTimeZone(inDate)
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
        public ActionResult getDiferentFormatTime([FromBody] InputTimeZoneModel inDate)
        {
            try
            {
                if (!_timeRepository.isCorrectDate(inDate.Datatime)) throw new Exception();
                var result = new
                {
                    ok = "ok",
                    result = _timeRepository.GetConvertTimeZone(inDate).TimeOfDay
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
