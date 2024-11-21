using Microsoft.AspNetCore.Mvc;

namespace FilmAndMovie.Controllers
{
    public class IzleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
