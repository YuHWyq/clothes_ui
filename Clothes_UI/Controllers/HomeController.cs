﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clothes_UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //hhfhfh
            return View();
        }

        public ActionResult About()
        {
            //yhyhyh
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}