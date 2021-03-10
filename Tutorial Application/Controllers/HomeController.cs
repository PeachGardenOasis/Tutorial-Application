using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Tutorial_Application.Models;

namespace Tutorial_Application.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            var contacts = new Dictionary<string, string>
            {
                {"Phone","416-123-4567" },
                {"Email","someone@isp.ca" },
                {"Facebook","facebook.ca/mywebsite" },

        };
            return View(contacts);
        }

    }
}
