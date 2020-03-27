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
        private TallerContext _db = new TallerContext();

        [HttpGet]
        public ActionResult Index()
        {
            List<Repuesto> Repuestos = _db.Repuestos.ToList();
            return View(Repuestos);
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
                _db = new TallerContext();
                _db.Repuestos.Add(r);
                _db.SaveChanges();
                return RedirectToAction("Index", "Repuestos");
            }
            return View(r);
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            Repuesto r = null;
            using (_db = new TallerContext())
            {
                r = _db.Repuestos.Find(id);
            }
            return View(r);
        }

        [HttpPost]
        public ActionResult Edit(int id, Repuesto r)
        {
            if (ModelState.IsValid)
            {
                _db = new TallerContext();
                _db.Entry(r).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index", "Repuestos", new { id = r.Id });
            }
            return View(r);
        }

        [HttpGet]
        public ActionResult Ver(int id)
        {
            Repuesto r = null;
            using (_db = new TallerContext())
            {
                r = _db.Repuestos.Find(id);
            }
            return View(r);
        }

        [HttpPost]
        public ActionResult Ver()
        {
            return RedirectToAction("Index", "Repuestos"); 
        }

    }
}