using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace InventaryProject.Areas.Inventory.Controllers
{
    [Area("Inventory")]
    public class InventoryController : Controller
    {

        private readonly ILogger<InventoryController> _logger;

        public InventoryController(ILogger<InventoryController> logger)
        {
            _logger = logger;
        }
        // GET: InventoryController
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


    }
}
