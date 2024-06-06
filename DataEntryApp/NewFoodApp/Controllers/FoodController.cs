using NewFoodApp.Models;
using NewFoodApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace NewFoodApp.Controllers
{
    public class FoodController : Controller
    {
        private IFoodService _foodService;
        public FoodController(IFoodService service)
        {
            _foodService = service;                        //Depndency Injection
        }

        public IActionResult Index()
        {
            List<Food> items = _foodService.GetAll();
            ViewData["items"] = items;
            return View();
        }
        public IActionResult Details(int id)
        {
            Food food = _foodService.GetById(id);
            ViewData["food"] = food;
            return View();
        }
        public IActionResult Remove(int id)
        {
            _foodService.Remove(id);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            Food theFood = _foodService.GetById(id);
            return View(theFood);
        }

        [HttpPost]
        public IActionResult Update(Food food)
        {
            _foodService.Update(food);
            return RedirectToAction("Index");
        }

        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(Food food)
        {
            _foodService.Insert(food);
            return RedirectToAction("Index");
        }
    }
}
