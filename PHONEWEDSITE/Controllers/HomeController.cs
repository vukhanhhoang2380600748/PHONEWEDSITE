using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhoneStore.DB;
using PHONEWEDSITE.Models;
using System.Diagnostics;

namespace PHONEWEDSITE.Controllers
{
    public class HomeController(PhoneStoreDbContext ctx) : Controller
    {
        readonly PhoneStoreDbContext _ctx = ctx;
        public async Task<IActionResult> Index()
        {
            var featured = await _ctx.Products
                .Where(o => o.Featured!.Value).Take(10)
                .ToListAsync();
            ViewBag.Featured = featured;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Products()
        {
            return View();
        }

        public IActionResult Details()
        {

            return View();
        }

        public IActionResult Carts()
        {
            return View();
        }
    }
}