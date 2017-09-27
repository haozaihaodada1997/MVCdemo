using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCdemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public string helle()
        {
            return "hello";
        }
        //返回值类型：ActionResult和ViewResult   前者是基类（抽象类） 后者是派生类
        //注意：以后在写的过程中，直接写ActionResult即可
        public ActionResult sun()
        {
            return Content("新时代开始了！！！");
        }
        public ViewResult Worp()
        {
            return View("index");
        }
        //返回的视图结果，如果没有任何参数，则返回默认的和方法名称保持一致的视图，如果指定了视图，则显示指定的视图界面
        public ActionResult skip()
        {
            return RedirectToAction("index", "Account");
        }
        public ActionResult LordTest()
        {
            Person p = new Person()
            {
                id = 8,
                name="张单",
            };
            //object是所有数据类型的基架
            return LordTest(/*p,JsonRequestBehavior.DenyGet*/);
        }
    }
    public class Person
    {
          public int id { get; set; }
          public string name { get; set; }
    }
}