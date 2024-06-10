using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SessionStorageApp.Models;

namespace SessionStorageApp.Controllers
{
    public class SignController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            Form theForm = new Form()
            {
                Email = "",
                Password = ""
            };
            return View(theForm);
        }

        [HttpPost]
        public IActionResult Login(Form theForm)
        {
            if (theForm.Email == "shubham@shubhamenterprises.in" &&
                theForm.Password == "king")
            {
                return RedirectToAction("index", "customers");
            }

            return View(theForm);
        }

        public IActionResult Register()
        {
            Customer newCustomer = new Customer();
            newCustomer.ShopList = PopulateShops();
            return View(newCustomer);
        }

        [HttpPost]
        public IActionResult Register(Customer theCustomer, string[] shops)
        {
            theCustomer.ShopList = PopulateShops();
            foreach (SelectListItem item in theCustomer.ShopList)
            {
                if (item != null)
                {
                    if (shops.Contains(item.Value))
                    {
                        item.Selected = true;
                    }
                }
            }
            return RedirectToAction("Index");
        }

        public static List<SelectListItem> PopulateShops()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            items.Add(new SelectListItem { Text = "Papaya", Value = "Papaya", Selected = false });
            items.Add(new SelectListItem { Text = "Grapes", Value = "Grapes", Selected = false });
            items.Add(new SelectListItem { Text = "Orange", Value = "Orange", Selected = false });
            items.Add(new SelectListItem { Text = "Onion", Value = "Onion", Selected = false });
            items.Add(new SelectListItem { Text = "Banana", Value = "Banana", Selected = false });
            return items;
        }
    }
}
