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
    public class UniformesController : Controller
    {
        IUniformes uni;

        public UniformesController()
        {
            uni = new MUniformes();

        }
        // GET: Uniformes
        public ActionResult Index()
        {
            var listaUniformes = uni.ListaUniformes();
            var uniformesListar = Mapper.Map<List<Models.Uniformes>>(listaUniformes);
            return View(uniformesListar);
        }



        // GET: Producto/Details/5
        public ActionResult Details(int id)
        {
            var uniformes = uni.BuscarUniformes(id);
            var uniformesMostrar = Mapper.Map<Models.Uniformes>(uniformes);
            return View(uniformesMostrar);
        }

        // GET: Producto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Producto/Create
        [HttpPost]
        public ActionResult Create(Uniformes uniformes)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var uniformesInsertar = Mapper.Map<DATA.Uniformes>(uniformes);
                uni.AgregarUniformes(uniformesInsertar);
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
            var uniformes = uni.BuscarUniformes(id);
            var uniformesMostrar = Mapper.Map<Models.Uniformes>(uniformes);
            return View(uniformesMostrar);
        }

        // POST: Producto/Edit/5
        [HttpPost]
        public ActionResult Edit(Uniformes uniformes)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var uniformesActualizar = Mapper.Map<DATA.Uniformes>(uniformes);
                uni.ActualizarUniformes(uniformesActualizar);
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
            uni.EliminarUniformes(id);
            return View();
        }
    }
}