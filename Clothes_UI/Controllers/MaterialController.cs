using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clothes_UI.Controllers
{
    public class MaterialController : Controller
    {
        // GET: Material
        public ActionResult Index()
        {
            return View();
        }
        //原料库存
        public ActionResult Material()
        {
            return View();
        }
        //材料入库
        public ActionResult materialr_in()
        {
            return View();
        }
        //材料出库
        public ActionResult out_materialr()
        {
            return View();
        }
        //出入库统计
        public ActionResult Statistics()
        {
            return View();
        }

        //新增原料
        public ActionResult AddYL()
        {
            return View();
        }
        
    }
}