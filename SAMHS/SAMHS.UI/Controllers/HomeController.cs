using AutoMapper;
using SAMHS.DAL.Interfaces;
using SAMHS.DAL.Metodos;
using SAMHS.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAMHS.UI.Controllers
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

        public ActionResult Deposito()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Deposito (HttpPostedFileBase file)
        {
            Deposito modelo = new Deposito();
            if (file != null)
            {
                string ruta = Server.MapPath("~/Depositos/");
                ruta += file.FileName;
                modelo.SubirArchivo(ruta, file);
                ViewBag.Error = modelo.error;
                ViewBag.Correcto = modelo.confirmacion;
            }
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
    }
}