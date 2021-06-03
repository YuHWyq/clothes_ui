using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clothes_UI.Controllers
{
    public class ProductionController : Controller
    {
        // GET: Production
        //计划管理
        public ActionResult Index()
        {
            return View();
        }
        //添加计划生产单
        public ActionResult add()
        {
            return View();
        }
        //领料管理
        public  ActionResult Production()
        {
            return View();
        }
        //添加领料管理
        public ActionResult Productionadd()
        {
            return View();
        }
        //产品生产
        public ActionResult Productions()
        {
            return View();
        }
    }
}