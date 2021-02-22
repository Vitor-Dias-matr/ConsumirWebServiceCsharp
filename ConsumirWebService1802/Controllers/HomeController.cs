using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConsumirWebService1802.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Soma(double num1, double num2)
        {
            JsonResult js = new JsonResult();
            localhost.WebService1 soma = new localhost.WebService1();
            //soma.Soma(num1, num2);
            soma.Url = "https://localhost:44304/WebService1.asmx";
            var resultado = js.Data = soma.Soma(num1, num2);
            js.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return Json(new {success = resultado});
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
    }
}