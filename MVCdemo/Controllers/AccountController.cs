using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCdemo.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ParmTest()
        {
            return View();
        }
        public ActionResult RouteTest(int id)
        {
            ViewData["id"] = id;
            return View();
        }
        public ActionResult FormParm(FormCollection fm)
        {
            ViewBag.id= fm["uid"];
            ViewBag.name = fm["uname"];
            ViewBag.address = fm["uaddress"];
            return View();
        }
    }
}