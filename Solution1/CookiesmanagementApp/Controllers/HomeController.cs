using System.Diagnostics;
using CookiesmanagementApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CookiesmanagementApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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

        public IActionResult CreateCookie()

        {
            String key = "Cookie";
            String value = "Ritesh";
            CookieOptions obj = new CookieOptions();
            obj.Expires = DateTime.Now.AddMinutes(10);
            Response.Cookies.Append(key, value, obj);
            return View();
        }

        public IActionResult DisplayCookie()
        {
            String key = "Cookie";
            var CookieValue = Request.Cookies[key];
            ViewBag.cookieVal = CookieValue;
            return View();
        }

    }
}
