using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clothes_UI.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        //产品库存管理
        public ActionResult Index()
        {
            return View();
        }
        //添加产品入库单
        public ActionResult Product()
        {
            return View();
        }
        //产品入库管理
        public ActionResult Products()
        {
            return View();
        }
        //添加产品出库单
        public ActionResult Productes()
        {
            return View();
        }
        //产品出库单管理
        public ActionResult Productees()
        {
            return View();
        }
    }
}