using Microsoft.AspNetCore.Mvc;

namespace TuanBuy.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Product()
        {
            return View("Index");
        }
        
    }
}
