using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fe_0302.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult VNExpress()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult BT2a_Lab01()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult BT2b_Lab01()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Bt1_Lab01()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Bt3_Lab01()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Vd1()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Products(){
            ViewBag.Message = "Hi";
            return View();
        }
    }
}