using Microsoft.AspNetCore.Mvc;
using NewFoodApp.Models;

namespace NewFoodApp.Controllers
{
    public class StatsboardController : Controller
    {
        public IActionResult Index()
        {
            List<ChartData> charData = ChartData.GetData();
            return View(charData);
        }

        public IActionResult LineChartView() 
        {
            return View();
        }

        public IActionResult BarChartView()
        {
            List<ChartData> charData = ChartData.GetData();

            return View(charData);
        }

        public IActionResult PieChartView()
        {
            return View();
        }
    }
}
