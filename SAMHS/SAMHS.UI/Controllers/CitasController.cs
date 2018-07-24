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
    public class CitasController : Controller
    {
       
        ICitas cit;
       
        public CitasController ()
        {
            cit = new MCitas();
           
        }
        // GET: Citas
        public ActionResult Index()
        {
            var listaCitas = cit.ListaCitas();
            var citasListar = Mapper.Map<List<Models.Citas>>(listaCitas);
            return View(citasListar);
        }

       

          // GET: Producto/Details/5
        public ActionResult Details(int id)
        {
            var citas = cit.BuscarCitas(id);
            var citasMostrar = Mapper.Map<Models.Citas>(citas);
            return View(citasMostrar);
        }

        // GET: Producto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Producto/Create
        [HttpPost]
        public ActionResult Create(Citas citas)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var citasInsertar = Mapper.Map<DATA.Citas>(citas);
                cit.AgregarCitas(citasInsertar);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Producto/Edit/5
        public ActionResult Edit(int id)
        {
            var citas = cit.BuscarCitas(id);
            var citasMostrar = Mapper.Map<Models.Citas>(citas);
            return View(citasMostrar);
        }

        // POST: Producto/Edit/5
        [HttpPost]
        public ActionResult Edit(Citas citas)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var citasActualizar = Mapper.Map<DATA.Citas>(citas);
                cit.ActualizarCitas(citasActualizar);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Producto/Delete/5
        public ActionResult Delete(int id)
        {
            cit.EliminarCitas(id);
            return View();
        }
    }
}