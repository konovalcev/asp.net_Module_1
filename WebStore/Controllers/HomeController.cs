﻿using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Login() => View();
        public IActionResult ContactUs() => View();
        public IActionResult Checkout() => View();
        public ActionResult Cart() => View();
        public IActionResult BlogSingle() => View();
        public IActionResult Blog() => View();
        public new IActionResult NotFound() => View();

    }
}