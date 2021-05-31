using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clothes_UI.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        //主页
        public ActionResult Index()
        {
            return View();
        }
    }
}