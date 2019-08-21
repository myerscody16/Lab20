using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Lab20.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace Lab20.Controllers
{
    public class HomeController : Controller
    {
        List<RegisterUser> listOfUsers = new List<RegisterUser>() { };
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
        public IActionResult AddNewUser(RegisterUser user)
        {
            string listOfUsersJson = HttpContext.Session.GetString("ListOfUsersSession");
            if (listOfUsersJson != null)
            {
                listOfUsers = JsonConvert.DeserializeObject<List<RegisterUser>>(listOfUsersJson);
            }
            listOfUsers.Add(user);
            HttpContext.Session.SetString("ListOfUsersSession", JsonConvert.SerializeObject(listOfUsers));
            return View("ListAllUsers");
        }
        [Authorize]
        public IActionResult ListAllUsers()
        {
            string listOfUsersJson = HttpContext.Session.GetString("ListOfUsersSession");
            if (listOfUsersJson != null)
            {
                listOfUsers = JsonConvert.DeserializeObject<List<RegisterUser>>(listOfUsersJson);
            }
            return View();
        }
        public IActionResult UserLogin()
        {
            return View();
        }
        
        
    }
}
