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
        //客户资料
        public  ActionResult Customer()
        {
            return View();
        }
        //订单管理
        public ActionResult Order()
        {
            return View();
        }
        //添加订单
        public ActionResult InsertOrder()
        {
            return View();
        }
    }
}