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
        //客户资料
        public ActionResult Customer()
        {
            return View();
        }

        //添加客户资料信息
        public ActionResult InsertCustomerInformation()
        {
            return View();
        }
        //订单管理
        public ActionResult manage()
        {
            return View();
        }
        //添加订单
        public ActionResult insertmanage()
        {
            return View();

        }
        //订单跟踪
        public ActionResult track()
        {
            return View();
        }
     
       
    }
}