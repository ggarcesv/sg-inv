using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TallerMecanico.Models;

namespace TallerMecanico.Controllers
{
    public class MarcasController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            Marca m = new Marca();
            return View(m);

        }

        [HttpPost]
        public ActionResult Create(Marca m)
        {
            if (ModelState.IsValid)
            {
                // por aqui guardamos en la base de datos
                return RedirectToAction("Index", "Marcas");
            }
            return View(m);
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, Marca m)
        {
            if (ModelState.IsValid)
            {
                // por aqui guardamos en la base de datos
                return RedirectToAction("View", "Marcas", new { id = id });
            }
            return View(m);
        }

        [HttpGet]
        public ActionResult Ver()
        {
            return View();
        }
    }
}