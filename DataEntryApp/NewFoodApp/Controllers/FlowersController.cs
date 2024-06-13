using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;

namespace NewFoodApp.Controllers
{
    public class FlowersController : Controller
    {
        //[OutputCache(PolicyName = "CacheFor30Seconds")]
        [OutputCache]
        public IActionResult Index()
        
        {
            List<string> list = new List<string>();
            list.Add("Rose");
            list.Add("Jasmine");
            return Json(list);
        }
    }
}
