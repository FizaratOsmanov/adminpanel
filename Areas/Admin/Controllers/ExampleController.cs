using Microsoft.AspNetCore.Mvc;
namespace AdminPanel.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }
    }
}
