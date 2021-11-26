using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSessionManagement.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username,string password)
        {
            if(username!= null && password != null)
            {
                if (username.Equals("admin") && password.Equals("admin"))
                {
                    HttpContext.Session.SetString("uname", username);
                    return View("Success");
                }
                else
                {
                    ViewBag.Error = "Invalid credentials";
                    return View("Index");
                }
            }
            else
            {
                ViewBag.Error = "Enter your credentials";
                return View("Index");
            }
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }
    }
}
