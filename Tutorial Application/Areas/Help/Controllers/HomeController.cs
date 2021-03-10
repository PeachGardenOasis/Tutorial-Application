using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial_Application.Areas.Help.Controllers
{
    [Area("Help")] // operates only in help area
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
