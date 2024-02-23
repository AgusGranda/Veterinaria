using Microsoft.AspNetCore.Mvc;

namespace Veterinaria.Controllers
{
    public class AnimalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
