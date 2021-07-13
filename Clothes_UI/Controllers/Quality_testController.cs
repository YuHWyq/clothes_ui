using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clothes_UI.Controllers
{
    public class Quality_testController : Controller
    {
        // GET: Quality_test
        //待检产品
        public ActionResult Index()
        {
            return View();
        }
        //产品质检单
        public   ActionResult Quality_test()
        {
            return View();
        }
    }
}