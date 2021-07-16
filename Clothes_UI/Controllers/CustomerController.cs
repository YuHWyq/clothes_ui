using Clothes_UI.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clothes_UI.Controllers
{
    public class CustomerController : Controller
    {
        ClothingDBEntities6 db = new ClothingDBEntities6();
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
        [HttpGet]
        //根据ID查询客户信息
        public string chaxunID(int id)
        {
            db.Configuration.ProxyCreationEnabled = false;
            var c = from cc in db.customer 
                    where(cc.customer_id==id)
                    select cc;
            int s = c.Count();
            return Newtonsoft.Json.JsonConvert.SerializeObject(c);
        }
        //详情查询
        [HttpGet]
        public string order_details(int id)
        {
            db.Configuration.ProxyCreationEnabled = false;
            var list =
                from od in db.order_details
                join
p in db.product on od.product_id equals p.product_id
                where (od.order_id==id)
                select new
                {
                    order_details_id = od.order_details_id,
                    order_id = od.order_id,
                    product_id = od.product_id,
                    product_name = p.product_name,
                    quantity = od.quantity,
                };
            return Newtonsoft.Json.JsonConvert.SerializeObject(list);
        }
        //商品详情信息添加
        [HttpGet]
        public string productname()
        {
            db.Configuration.ProxyCreationEnabled = false;
            var list = from p in db.product
                       select new { name = p.product_name};
            return Newtonsoft.Json.JsonConvert.SerializeObject(list);
        }
        //查询客户名
        [HttpGet]
        public string customername()
        {
            db.Configuration.ProxyCreationEnabled = false;
            var list = from p in db.customer
                       select new { name = p.customer_name };
            return Newtonsoft.Json.JsonConvert.SerializeObject(list);
        }
        [HttpGet]
        public string productnameselete(string name)
        {
            db.Configuration.ProxyCreationEnabled = false;
            var list = from p in db.product
                       where (p.product_name==name)
                       select new {
                           product_name = p.product_name,
                           product_id=p.product_id,
                           size=p.size,
                           product_type=p.product_type,
                           unit=p.unit,
                           product_price=p.product_price,
                           product_address=p.product_address,
                           product_num = p.product_num,
                           product_producer=p.product_producer

                       };
            return Newtonsoft.Json.JsonConvert.SerializeObject(list);
        }
        //保存修改的信息
        [HttpGet]
        public string UpCustomer(string json)
        {
            db.Configuration.ProxyCreationEnabled = false;
            JObject json1 = (JObject)JsonConvert.DeserializeObject(json);
            int id = int.Parse(json1.Root["customer_id"].ToString());
            customer cu = db.customer.FirstOrDefault(p => p.customer_id == id);
            cu.customer_id = id;
            cu.customer_name = json1.Root["customer_name"].ToString();
            cu.customer_address = json1.Root["customer_address"].ToString();
            cu.bank = json1.Root["bank"].ToString();
            cu.bank_account = json1.Root["bank_account"].ToString();
            cu.customer_email = json1.Root["customer_email"].ToString();
            cu.customer_fax = json1.Root["customer_fax"].ToString();
            cu.customer_linkman = json1.Root["customer_linkman"].ToString();
            cu.customer_phone = json1.Root["customer_phone"].ToString();
            cu.customer_postcode = json1.Root["customer_postcode"].ToString();
            db.Entry(cu).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return "";
        }
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
        //订单统计
        public ActionResult track()
        {
            return View();
        }
        //新增客户订单
        [HttpPost]
        public int add_customer_order(string json)
        {
            JObject json1 = (JObject)JsonConvert.DeserializeObject(json);
            JArray array = (JArray)json1["infoList"];
            //先新增计划表+
            string custemer_name = json1.Root["customer_name"].ToString();
            //根据名字查询用户ID
            string orderrid = (((DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000) * 1000).ToString();
            int custmerid = db.customer.Where
                (p => p.customer_name.Contains(custemer_name)).ToList()[0].customer_id;
            orders pp = new orders();
            pp.customer_id = custmerid;
            pp.order_starttime = (DateTime)json1.Root["order_starttime"];
            pp.order_endtime = ((DateTime)json1.Root["order_endtime"]);
            pp.person_handling = json1.Root["person_handling"].ToString();
            pp.operator_per = json1.Root["operator_per"].ToString();
            pp.order_paid = decimal.Parse(json1.Root["order_paid"].ToString());
            pp.order_unpaid = decimal.Parse(json1.Root["order_unpaid"].ToString());
            pp.order_status = json1.Root["order_status"].ToString();
            pp.ss = orderrid;
            //首先新增订单表数据
            db.orders.Add(pp);
            //保存数据
            db.SaveChanges();
            //新增订单详情
            foreach (var jObject in array)
            {
                //查询
                int id = db.orders.Where(p => p.ss == orderrid).ToList()[0].order_id;
                order_details ppd = new order_details();
                //赋值属性
                ppd.order_id =id;
                ppd.product_id = int.Parse(jObject["product_id"].ToString());
                ppd.quantity = int.Parse(jObject["product_details_num"].ToString());
                ppd.order_details_money = 41700;
                //再新增详情表数据
                db.order_details.Add(ppd);
                //保存数据
                db.SaveChanges();
            }
            return 0;
        }

    }
}