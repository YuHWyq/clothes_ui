using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clothes_UI.Models;

namespace Clothes_UI.Controllers
{
    public class Quality_testController : Controller
    {
        ClothingDBEntities3 db = new ClothingDBEntities3();
        // GET: Quality_test
        //待检产品
        public ActionResult Index()
        {
            var goods = db.Database.SqlQuery<Quality_test_index_selecte_Result>("exec Quality_test_index_selecte").ToList();
            return View(goods);
        }
        [HttpPost]
        public ActionResult Indexadd(product_quality_testing product_Quality_Testing)
        {
            db.product_quality_testing.Add(product_Quality_Testing);
            db.SaveChanges();
            return Content("<script>alert('质检完成!');location.href='/Quality_test/Index'</script>");
        }
        //产品质检单
        public   ActionResult Quality_test()
        {
            var goods = db.Database.SqlQuery<Product_Quality_test_selecte_Result>("exec Product_Quality_test_selecte").ToList();
            return View(goods);
        }
    }
}