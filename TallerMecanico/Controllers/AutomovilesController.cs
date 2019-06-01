using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TallerMecanico.Models;

namespace TallerMecanico.Controllers
{
    public class AutomovilesController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            Automovil auto = new Automovil();
            return View(auto);
        }

        [HttpPost]
        public ActionResult Create(Automovil auto)
        {
            if (ModelState.IsValid)
            {
                // por aqui guardamos en la base de datos
                return RedirectToAction("Index", "Automoviles");
            }
            return View(auto);
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, Automovil auto)
        {
            if (ModelState.IsValid)
            {
                // por aqui guardamos en la base de datos
                return RedirectToAction("View", "Automoviles", new { id = id });
            }
            return View(auto);
        }
      
        [HttpGet]
        public ActionResult Ver()
        {
            return View();
        }
    }
}