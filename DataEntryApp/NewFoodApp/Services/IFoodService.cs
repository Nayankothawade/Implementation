using NewFoodApp.Models;

namespace NewFoodApp.Services
{
    public interface IFoodService
    {
        List<Food> GetAll();
        Food GetById(int id);
        void Remove(int id);
        void Insert(Food food);
        void Update(Food food);
    }
}
