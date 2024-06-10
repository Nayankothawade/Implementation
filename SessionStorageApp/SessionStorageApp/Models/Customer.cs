using Microsoft.AspNetCore.Mvc.Rendering;

namespace SessionStorageApp.Models
{
    public class Customer
    {
        public string GSTN { get; set; }
        public string Name { get; set; }
        public List<SelectListItem> ShopList { get; set; }
        public Customer()
        {
            ShopList = new List<SelectListItem>();
        }
    }
}
