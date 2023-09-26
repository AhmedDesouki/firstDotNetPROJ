using Microsoft.AspNetCore.Mvc;

namespace firstDotNetPROJ.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
