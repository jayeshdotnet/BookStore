﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jk.BookStore.Controllers
{
    public class HomeController : Controller
    {
        // method 
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult AboutUs()
        {
            return View();
        }
        public ViewResult ContactUs()
        {
            return View();
        }
    }
}

