using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clothes_UI.Controllers
{
    public class HomeController : Controller
    {
        //首页
       public ActionResult Home()
        {
            return View();
        }
    }
}