using NewFoodApp.Models;

namespace NewFoodApp.Services
{
    public class FoodService : IFoodService
    {
        private List<Food> items;

        public FoodService() 
        {
            items = new List<Food>();
            items.Add(new Food { Id = 21, Name = "Noodles", Price = 120 });
            items.Add(new Food { Id = 22, Name = "Pav Bhaji", Price = 150 });
            items.Add(new Food { Id = 23, Name = "Veg Biryani", Price = 280 });
            items.Add(new Food { Id = 24, Name = "Kofta Curry", Price = 310 });
        }

        public List<Food> GetAll() 
        {
            return items;
        }

        public Food GetById(int id)
        {
            return items.Find(f => f.Id == id);
        }

        public void Insert(Food food)
        {
            items.Add(food);
        }

        public void Remove(int id)
        {
            var existingFood = items.FirstOrDefault(f => f.Id == id);
            if (existingFood != null)
            {
                items.Remove(existingFood);
            }
        }

        public void Update(Food food)
        {
            var existingFood = items.FirstOrDefault(f => f.Id == food.Id);
            if (existingFood != null)
            {
                items[items.IndexOf(existingFood)] = food;
            }
        }
    }
}
