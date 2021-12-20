using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchoolFaceControllApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolFaceControllApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult SingleStudent()
        {
            return View();
        }
        public IActionResult Temperature()
        {
            return View();
        }

        public IActionResult Missing()
        {
            return View();
        }
        public IActionResult Late()
        {
            return View();
        }
        public IActionResult NotFound()
        {
            return View();
        }
    }
}
