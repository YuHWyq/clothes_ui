using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clothes_UI.Controllers
{
    public class PurchaseController : Controller
    {
        // GET: Purchase
        public ActionResult Index()
        {
            return View();
        }
        //添加采购计划添加采购单
        public ActionResult Purchase()
        {
            return View();
        }
        //采购订单管理
    public ActionResult ordermanagement()
        {
            return View();
        }
    }
}