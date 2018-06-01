using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webRenap.Controllers
{
    public class RenapController : Controller
    {
        // GET: Renap
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Solicitud()
        {
            return View();
        }

        public ActionResult Certificado()
        {
            return View();
        }
    }
}