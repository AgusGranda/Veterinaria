using Microsoft.AspNetCore.Mvc;

namespace Veterinaria.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
