using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clothes_UI.Models;

namespace Clothes_UI.Controllers
{
    public class ProductionController : Controller
    {
        ClothingDBEntities3 db = new ClothingDBEntities3();
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
        [HttpPost]
        public ActionResult product_planadd(product_plan product_Plan)
        {
            db.product_plan.Add(product_Plan);
            db.SaveChanges();
            return Content("<script>alert('添加成功!');location.href='/Production/Index'</script>");
        }
        //领料管理
        public  ActionResult Production() { 
             var goods = db.get_materials.ToList();
             return View(goods);
        }  
        //添加领料管理
        public ActionResult Productionadd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult get_materialsadd(get_materials get_Materials)
        {
            db.get_materials.Add(get_Materials);
            db.SaveChanges();
            return Content("<script>alert('添加成功!');location.href='/Production/Production'</script>");
        }
        //产品生产
        public ActionResult Productions()
        {
            var goods = db.Database.SqlQuery<Production_Productions_selecte_Result>("exec Production_Productions_selecte").ToList();
            return View(goods);
        }
        //添加产品生产登记
        public ActionResult Productionsadd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Productionsaddadd(pro_production pro_Production)
        {
            db.pro_production.Add(pro_Production);
            db.SaveChanges();
            return Content("<script>alert('添加成功!');location.href='/Production/Productions'</script>");
        }
        public ActionResult ss()
        {
            return View();
        }
    }
}