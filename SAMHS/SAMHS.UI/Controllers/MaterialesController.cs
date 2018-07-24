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
    public class MaterialesController : Controller
    {
        IMateriales mat;

        public MaterialesController()
        {
            mat = new MMateriales();

        }
        // GET: Materiales
        public ActionResult Index()
        {
            var listaMateriales = mat.ListaMateriales();
            var materialesListar = Mapper.Map<List<Models.Materiales>>(listaMateriales);
            return View(materialesListar);
        }



        // GET: Producto/Details/5
        public ActionResult Details(int id)
        {
            var materiales = mat.BuscarMateriales(id);
            var materialesMostrar = Mapper.Map<Models.Materiales>(materiales);
            return View(materialesMostrar);
        }

        // GET: Producto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Producto/Create
        [HttpPost]
        public ActionResult Create(Materiales materiales)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var materialesInsertar = Mapper.Map<DATA.Materiales>(materiales);
                mat.AgregarMateriales(materialesInsertar);
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
            var materiales = mat.BuscarMateriales(id);
            var materialesMostrar = Mapper.Map<Models.Materiales>(materiales);
            return View(materialesMostrar);
        }

        // POST: Producto/Edit/5
        [HttpPost]
        public ActionResult Edit(Materiales materiales)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var materialesActualizar = Mapper.Map<DATA.Materiales>(materiales);
                mat.ActualizarMateriales(materialesActualizar);
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
            mat.EliminarMateriales(id);
            return View();
        }
    }
}