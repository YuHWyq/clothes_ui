using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clothes_UI.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        //客户管理
        public  ActionResult Customer()
        {
            return View();
        }
    }
}