using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuanBuy.Controllers
{
    public class TestBackMangeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OrderManger()
        {
            return View();
        }
        public IActionResult UserManger()
        {
            return View();
        }
        public IActionResult ProductMangedown()
        {
            return View();
        }
        public IActionResult ProductMangeup()
        {
            return View();
        }
    }
}
