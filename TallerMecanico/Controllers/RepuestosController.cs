using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TallerMecanico.Models;

namespace TallerMecanico.Controllers
{
    public class RepuestosController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Create()
        {
            Repuesto r = new Repuesto();
            return View(r);

        }

        [HttpPost]
        public ActionResult Create(Repuesto r)
        {
            if (ModelState.IsValid)
            {
                // por aqui guardamos en la base de datos
                return RedirectToAction("Index", "Repuestos");
            }
            return View(r);
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, Repuesto r)
        {
            if (ModelState.IsValid)
            {
                // por aqui guardamos en la base de datos
                return RedirectToAction("View", "Repuestos", new { id = id });
            }
            return View(r);
        }

        [HttpGet]
        public ActionResult Ver()
        {
            return View();
        }
    }
}