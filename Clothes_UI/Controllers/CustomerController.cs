using Clothes_UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clothes_UI.Controllers
{
    public class CustomerController : Controller
    {
        ClothingDBEntities4 db = new ClothingDBEntities4();
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
       //客户资料新增
        public ActionResult Insert(customer Customer)
        {
            db.customer.Add(Customer);
            db.SaveChanges();
            return RedirectToAction("Customer");
        }
        //删除客户资料
        public ActionResult Delete(int id)
        {
            var customer = db.customer.Find(id);
            db.customer.Remove(customer);
            db.SaveChanges();
            //重定向Action
            return RedirectToAction("Customer");
        }
        //客户资料查询
        public ActionResult Customer()
        {
          var Customer= db.customer.ToList();
            return View(Customer);
        }
        //客户订单管理查询
        //public ActionResult Order(order order)
        //{
        //     db.order.ToList();
        //    return View(order);
        //}
        //添加客户资料信息
        public ActionResult InsertCustomerInformation()
        {
            return View();
        }
        //订单管理
        public ActionResult manage()
        {
            var orders =  db.orders.ToList();
            return View(orders);
        }
        //添加订单
        public ActionResult insertmanage()
        {
            var insert = db.product.ToList();
            return View(insert);

        }
        //订单跟踪
        public ActionResult track()
        {
            return View();
        }
     
       
    }
}