using Microsoft.AspNetCore.Mvc;
using DataEntryApp.Models;
using DataEntryApp.Repository;
using Microsoft.AspNetCore.Http.Features;

namespace DataEntryApp.Controllers
{
    public class FoodController : Controller
    {

        /* public FoodController (FoodRepository repo)
        {
           _foodRepository = repo;
        } */
        
        public IActionResult Index()
        {
            FoodRepository _foodRepository = new FoodRepository();
            List <Food> list = _foodRepository.GetItems();
            ViewData["items"] = list;
            return View();
        }

        public IActionResult Details(int id)
        {
            FoodRepository _foodRepository = new FoodRepository();
            Food item = _foodRepository.GetById(id);
            ViewData["singleitem"] = item;
            return View();
        }

        public IActionResult Remove(int id)
        {
            FoodRepository _foodRepository = new FoodRepository();
            _foodRepository.Remove(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(Food food)
        {
            FoodRepository _foodRepository = new FoodRepository();
            _foodRepository.Insert(food);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            FoodRepository _foodRepository = new FoodRepository();
            Food fooditem = _foodRepository.GetById(id);    
            return View(fooditem);
        }

        [HttpPost]
        public IActionResult Edit(Food food)
        {
            FoodRepository _foodRepository = new FoodRepository();
            _foodRepository.Update(food);
            return RedirectToAction("Index");
        }
    }
}
