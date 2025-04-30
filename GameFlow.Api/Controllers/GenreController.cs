using Microsoft.AspNetCore.Mvc;

namespace GameFlow.Api.Controllers
{
    public class GenreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
