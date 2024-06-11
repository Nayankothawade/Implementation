using CookiesmanagementApp.Models;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace CookiesmanagementApp.Controllers
{
    public class ShoppingCartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddToCart([FromQuery] string product)
        {
            string json = null;
            json = HttpContext.Session.GetString("cart");
            if (json != null)
            {
                Cart theCart = JsonSerializer.Deserialize<Cart>(json);
                theCart.Items.Add(product);
                json = JsonSerializer.Serialize(theCart);
            }
            else
            {
                Cart theCart = new Cart();
                theCart.Items.Add(product);
                json = JsonSerializer.Serialize(theCart);
            }
            HttpContext.Session.SetString("cart", json);
            return RedirectToAction("cart");
        }

        public IActionResult Cart()
        {
            string json = null;
            json = HttpContext.Session.GetString("cart");
            if (json != null)
            {
                Cart existingCart = JsonSerializer.Deserialize<Cart>(json);
                ViewData["mycart"] = existingCart;
            }
            return View();
        }
    }
}
