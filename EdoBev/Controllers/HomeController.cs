using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EdoBev.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            @ViewBag.MioContenuto = "Sono in index!";
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";
            @ViewBag.MioContenuto = "Esempio";
            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}