using Microsoft.AspNetCore.Mvc;

namespace BigMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
