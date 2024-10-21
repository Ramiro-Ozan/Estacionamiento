using Microsoft.AspNetCore.Mvc;

namespace Estacionamiento.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction(nameof(Index), "Clientes");
        }
    }
}
