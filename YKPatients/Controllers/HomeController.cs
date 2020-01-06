using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YKPatients.Models;

namespace YKPatients.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Section"] = "Welcome";
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["section"] = "Privacy";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
