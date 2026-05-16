using Microsoft.AspNetCore.Mvc;

namespace PHONEWEDSITE.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

    }
}