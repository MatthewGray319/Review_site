﻿using Microsoft.AspNetCore.Mvc;

namespace Review_Project.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
