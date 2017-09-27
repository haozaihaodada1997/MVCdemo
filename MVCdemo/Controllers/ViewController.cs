using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCdemo.Controllers
{
    public class ViewController : Controller
    {
        // GET: View
        public ActionResult Index()
        {
            ViewData["data"] = "hello";
            ViewBag.bag = "wrold";
            return View();
        }
        public ActionResult select()
        {
            List<Person> p = new List<Person>();
          
            p.Add(new Person()
            {
                id=3,
                name="zaizai",
                address="bj"
            });
            p.Add(new Person()
            {
                id =8 ,
                name = "zai",
                address = "dj"
            });
            p.Add(new Person()
            {
                id = 3,
                name = "zai",
                address = "bf"
            });
            return View(p);
        }
        public class Person
        {
            public int id { get; set; }
            public string name { get; set; }
            public string address { get; set; }
        }
      
    }
}