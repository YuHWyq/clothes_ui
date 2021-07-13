using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clothes_UI.Controllers
{
    public class SaleController : Controller
    {
        // GET: Sale
        public ActionResult Index()
        {
            return View();
        }
        //销售管理
        public ActionResult Sale()
        {
            return View();
        }
        //销售统计
        public ActionResult Sales()
        {
            return View();
        }
        //出库

        public ActionResult out_repertory()
        {
            return View();
        }
    }
}