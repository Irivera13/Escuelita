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
    public class CalendarioController : Controller
    {

        ICalendario cal;

        public CalendarioController()
        {
            cal = new MCalendario();

        }
        // GET: Calendario
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetEvents()
        {
            Calendario modelo = new Calendario();
            {
                var events = modelo.ToString();
                return new JsonResult { Data = events, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }

        //public ActionResult GetEvents()
        //{
        //    var listaCalendario = cal.ListaCalendario();
        //    var calendariosListar = Mapper.Map<List<Models.Calendario>>(listaCalendario);
        //    return View(calendariosListar);
        //}
    }
}