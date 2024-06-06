using DataEntryApp.Models;

namespace DataEntryApp.Repository
{
    public class FoodRepository
    {
        List<Food> items = new List<Food>();
        public FoodRepository() {
            items.Add(new Food { Id = 12, Name = "Paneer Chilli", Price = 250, Description = "Best Starter", Quantity = 4 });
            items.Add(new Food { Id = 13, Name = "Veg Biryani", Price = 320, Description = "Favourite Rice", Quantity = 3 });
            items.Add(new Food { Id = 14, Name = "Kaju Curry", Price = 280, Description = "Tasty Curry", Quantity = 4 });
            items.Add(new Food { Id = 15, Name = "Garlic Naan", Price = 80, Description = "Flavoured Bread", Quantity = 16 });
        } 

        public List<Food> GetItems()
        {
            return items;
        }

        public Food GetById(int id)
        {
            Food food = items.Find(x => x.Id == id);
            return food;
        }

        public void Remove(int id)
        {
            Food food = items.Find(x => x.Id == id);
            items.Remove(food);
        }

        public void Insert(Food food)
        {
            items.Add(food);
        }

        public void Update(Food food) 
        {
            var existingitem = items.FirstOrDefault(x => x.Id == food.Id);
            if (existingitem != null)
            {
                items[items.IndexOf(existingitem)] = food;
            }
        }
    }
}
