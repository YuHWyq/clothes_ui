using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clothes_UI.Models;

namespace Clothes_UI.Controllers
{
    public class ProductController : Controller
    {
        ClothingDBEntities3 db = new ClothingDBEntities3();
        // GET: Product
        //产品库存管理
        public ActionResult Index()
        {
            var goods = db.Database.SqlQuery<Product_index_selecte_Result>("exec Product_index_selecte").ToList();
            return View(goods);
        }
        //添加产品入库单
        public ActionResult Product()
        {
            var goods = db.Database.SqlQuery<Product_Productees_selecte_Result>("exec Product_Productees_selecte").ToList();
            return View(goods);
        }
        [HttpPost]
        public ActionResult Productadd(in_repertory in_Repertory)
        {
            db.in_repertory.Add(in_Repertory);
            db.SaveChanges();
            return Content("<script>alert('入库成功!');location.href='/Product/Products'</script>");
        }
        //产品入库管理
        public ActionResult Products()
        {
            var goods = db.in_repertory.ToList();
            return View(goods);
        }
        //添加产品出库单
        public ActionResult Productes()
        {
            var goods = db.Database.SqlQuery<Product_Productes_selecte_Result>("exec Product_Productes_selecte").ToList();
            return View(goods);
        }
        [HttpPost]
        public ActionResult Productesadd(out_repertory out_Repertory)
        {
            db.out_repertory.Add(out_Repertory);
            db.SaveChanges();
            return Content("<script>alert('出库成功!');location.href='/Product/Productees'</script>");
        }
        //产品出库单管理
        public ActionResult Productees()
        {
            var goods = db.out_repertory.ToList();
            return View(goods);
        }
    }
}