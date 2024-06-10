using Microsoft.AspNetCore.Mvc;
using SessionStorageApp.Models;

namespace SessionStorageApp.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LocalStorage()
        {
            return View();
        }
        public IActionResult SessionStorage()
        {
            return View();
        }
    }
}