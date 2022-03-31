using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuanBuy.Controllers
{
    public class BennyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
