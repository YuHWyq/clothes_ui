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
                var goods = db.Database.SqlQuery<Production_index_select_Result>("exec Production_index_select").ToList();
                return View(goods);
        }
        //删除生产计划
        public ActionResult Delete(int id)
        {
            var Product_plan = db.product_plan.Find(id);
            db.product_plan.Remove(Product_plan);
            db.SaveChanges();
            return Content("<script>alert('删除成功!');location.href='/Production/Index'</script>");
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
        [HttpPost]
        public ActionResult product_plan_detailsadd(product_plan_details product_Plan_Details)
        {
            db.product_plan_details.Add(product_Plan_Details);
            db.SaveChanges();
            return Content("<script>alert('添加成功!');location.href='/Production/Index'</script>");
        }
        //领料管理
        public  ActionResult Production() { 
             var goods = db.get_materials.ToList();
             return View(goods);
        }
        public ActionResult ProductionDelete(int id)
        {
            var get_material = db.get_materials.Find(id);
            db.get_materials.Remove(get_material);
            db.SaveChanges();
            return Content("<script>alert('删除成功!');location.href='/Production/Production'</script>"); 
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
        public ActionResult ProductionsDelete(int id)
        {
            var pro_productions = db.pro_production.Find(id);
            db.pro_production.Remove(pro_productions);
            db.SaveChanges();
            return Content("<script>alert('删除成功!');location.href='/Production/Productions'</script>");
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
        //生产计划详情
        [HttpGet]
        public string product_plan_details(int id)
        {
            var list1 = db.Database.SqlQuery<pro_plan_details_Result>("exec pro_plan_details " + id).ToList();
            return Newtonsoft.Json.JsonConvert.SerializeObject(list1);
        }
        //查询生产计划
        [HttpGet]
        public ActionResult select_product_plan(int id)
        {
            return RedirectToAction("Index",new { name=id});
        }
    }
}