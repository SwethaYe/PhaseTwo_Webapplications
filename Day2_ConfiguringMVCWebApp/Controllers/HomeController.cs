﻿using Microsoft.AspNetCore.Mvc;

namespace Day2_ConfiguringMVCWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();


        }

        public IActionResult Contact()
        {
            return View();

        }

        public IActionResult About()
        {
            return View();

        }
    }
}