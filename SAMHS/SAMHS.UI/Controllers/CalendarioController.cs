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

        public JsonResult Calendario()
        {
            //using (BDEntities dc = new BDEntities())
            {
                var events = cal.ListaCalendario();
                return new JsonResult { Data = events, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }

        //public ActionResult Calendario()
        //{
        //    var listaCalendario = cal.ListaCalendario();
        //    var calendariosListar = Mapper.Map<List<Models.Calendario>>(listaCalendario);
        //    return View(calendariosListar);
        //}
    }
}