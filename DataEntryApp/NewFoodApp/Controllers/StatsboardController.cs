using Microsoft.AspNetCore.Mvc;

namespace NewFoodApp.Controllers
{
    public class StatsboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LineChartView() 
        {
            return View();
        }

        public IActionResult BarChartView()
        {
            return View();
        }

        public IActionResult PieChartView()
        {
            return View();
        }
    }
}
