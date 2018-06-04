using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webRenap.Controllers
{
    public class RenapController : Controller
    {
        wsRenapCertificado.CertificadoClient certificado = new wsRenapCertificado.CertificadoClient();
        // GET: Renap
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection form)
        {
            var resultado = certificado.Certificado("");

            if (form != null)
            {
                return RedirectToAction("solicitud");
            } else
            {
                ViewBag.err = "El usuario o contraseña son incorrectos";
                return View();
            }
        }

        public ActionResult Solicitud()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Solicitud(FormCollection form)
        {
            if (form != null)
            {
                return RedirectToAction("Certificado");
            }
            else
            {
                ViewBag.err = "El CUI ingresado no esta registrado";
                return View();
            }
        }

        public ActionResult Certificado()
        {
            return View();
        }
    }
}