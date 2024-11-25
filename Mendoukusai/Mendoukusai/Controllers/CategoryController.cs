using Microsoft.AspNetCore.Mvc;

namespace Mendoukusai.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
