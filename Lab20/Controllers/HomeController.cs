using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab20.Models;

namespace Lab20.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult RegisterNewUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterNewUser(RegisterUser newUser)
        {
            if (!ModelState.IsValid)
            {
                return View(newUser);
            }
            else
            {
                return View("AddNewUser", newUser);
            }
        }
        public IActionResult AddNewUser()
        {

        }
    }
}
