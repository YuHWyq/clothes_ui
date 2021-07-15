using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clothes_UI.Controllers
{
    public class FinanceController : Controller
    {
        // GET: Finance
        public ActionResult Index()
        {
            return View();
        }
        //财务收入详情
        public ActionResult Finance()
        {
            return View();
        }

        //财务支出详情
        public ActionResult zhichuFinance()
        {
            return View();
        }
    }
}