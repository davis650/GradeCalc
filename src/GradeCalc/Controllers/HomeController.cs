using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GradeCalc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "GradeCalc's description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact Information";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
