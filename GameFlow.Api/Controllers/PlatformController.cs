using Microsoft.AspNetCore.Mvc;

namespace GameFlow.Api.Controllers
{
    public class PlatformController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
