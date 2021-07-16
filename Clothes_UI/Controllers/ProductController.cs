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
        ClothingDBEntities6 db = new ClothingDBEntities6();
        // GET: Product
        //产品库存管理
        public ActionResult Index()
        {
            var goods = db.Database.SqlQuery<Product_index_selecte_Result>("exec Product_index_selecte").ToList();
            return View(goods);
        }
        public ActionResult Delete(int id)
        {
            var pro_repertorys = db.pro_repertory.Find(id);
            db.pro_repertory.Remove(pro_repertorys);
            db.SaveChanges();
            return Content("<script>alert('删除成功!');location.href='/Product/Index'</script>");
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
            var query = db.product_quality_testing.FirstOrDefault(n => n.pro_production_id == in_Repertory.pro_production_id);
            query.quality_testing_id = query.quality_testing_id;
            query.result = "已入库";
            db.SaveChanges();
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
        public ActionResult ProductsDelete(int id)
        {
            var in_repertorys = db.in_repertory.Find(id);
            db.in_repertory.Remove(in_repertorys);
            db.SaveChanges();
            return Content("<script>alert('删除成功!');location.href='/Product/Products'</script>");
        }
        //添加产品出库单
        public ActionResult Productes()
        {
            var goods = db.Database.SqlQuery<Product_Productes_selecte_Result>("exec Product_Productes_selecte").ToList();
            return View(goods);
        }
        public ActionResult ProductesDelete(int id)
        {
            var order = db.orders.Find(id);
            db.orders.Remove(order);
            db.SaveChanges();
            return Content("<script>alert('删除成功!');location.href='/Product/Productes'</script>");
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
        public ActionResult ProducteesDelete(int id)
        {
            var out_repertorys = db.out_repertory.Find(id);
            db.out_repertory.Remove(out_repertorys);
            db.SaveChanges();
            return Content("<script>alert('删除成功!');location.href='/Product/Productees'</script>");
        }
    }
}