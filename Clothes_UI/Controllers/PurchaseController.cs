using Clothes_UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clothes_UI.Controllers
{
    public class PurchaseController : Controller
    {
        ClothingDBEntities2 db = new ClothingDBEntities2();
        // GET: Purchase
        public ActionResult Index()
        {
            return View();
        }
        //添加采购计划添加采购单
        public ActionResult Purchase()
        {
            var materialr = db.materialr.ToList();
            return View(materialr);
        }
        //采购订单管理
    public ActionResult ordermanagement()
        {
            var in_materialr = db.in_materialr.ToList();
            return View(in_materialr);
        }
    }
}