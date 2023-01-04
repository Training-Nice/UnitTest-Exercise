using Microsoft.AspNetCore.Mvc;

namespace UnitTest_Exercise.Controllers
{
    public class TimeZoneController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
