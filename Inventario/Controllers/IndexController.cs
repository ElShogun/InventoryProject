using Microsoft.AspNetCore.Mvc;

namespace Inventario.Controllers
{
    public class IndexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
