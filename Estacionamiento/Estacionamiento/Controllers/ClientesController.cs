using Microsoft.AspNetCore.Mvc;

namespace Estacionamiento.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
