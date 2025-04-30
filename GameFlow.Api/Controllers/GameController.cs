using Microsoft.AspNetCore.Mvc;

namespace GameFlow.Api.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
