using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tarea._3.programacion.web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Nosotros()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Galeria()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Blog()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contacto()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}