﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CLIENT.Controllers
{
    public class InterviewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}