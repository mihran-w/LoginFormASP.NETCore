using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Users()
        {
            return View(DataBase.DataBase.logins);
        }

        [HttpPost]
        public IActionResult Login(Login login)
        {
            DataBase.DataBase.logins.Add(login);
            return Redirect("/home");
        }
    }
}
