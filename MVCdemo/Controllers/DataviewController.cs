using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCdemo.Controllers
{
    public class DataviewController : Controller
    {
        public static List<Person> p = new List<Person>()
           {
            new Person { id = 0, name = "牛二", address = "北京" },
            new Person { id = 1, name = "张三", address = "河北" },
           };
        // GET: Dataview

        public ActionResult Index()
        {
            return View(p);
        }
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult AddData(int uid,string uname,string uaddress)
        {
            p.Add(new Person()
            {
                id=uid,
                name=uname,
                address=uaddress
            });
            return RedirectToAction("index");
        }
        public ActionResult delect(int id)
        {
            var y = p.First(x => x.id == id);
            p.Remove(y);
            return RedirectToAction("index");
        }
        public ActionResult eidt(int id)
        {
            Person s = p.First(x => x.id == id);
            return View(s);
        }
        public ActionResult eidts(int uid, string uname, string uaddress)
        {
            Person s = p.First(x => x.id == uid);
            s.name = uname;
            s.address = uaddress;
            return RedirectToAction("index");
        }
        public class Person
        {
            public int id { get; set; }
            public string name { get; set; }
            public string address { get; set; }
        }
    }
}