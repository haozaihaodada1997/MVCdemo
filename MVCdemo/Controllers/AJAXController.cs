using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCdemo.Controllers
{
    public class AJAXController : Controller
    {
        // GET: AJAX
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add()
        {
            return Content("hello world");
        }
        public ActionResult AddForm(int uid,string uname,int uage)
        { 
            return Content("编号"+uid+ ";姓名"+uname+";年龄" +uage);
        }
        public ActionResult ajax(int uid, string uname, int uage)
        {
            return Content("");
        }
    }
}