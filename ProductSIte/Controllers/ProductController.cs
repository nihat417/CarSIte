using Microsoft.AspNetCore.Mvc;

namespace ProductSIte.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
