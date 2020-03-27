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
        private TallerContext _db = new TallerContext();

        [HttpGet]
        public ActionResult Index()
        {
            List<Marca> Marcas = _db.Marcas.ToList();
            return View(Marcas);
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
                _db = new TallerContext();
                _db.Marcas.Add(m);
                _db.SaveChanges();
                return RedirectToAction("Index", "Marcas");
            }
            return View(m);
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            Marca m = null;
            using (_db = new TallerContext())
            {
                m = _db.Marcas.Find(id);
            }
            return View(m);
        }

        [HttpPost]
        public ActionResult Edit(Marca m)
        {
            if (ModelState.IsValid)
            {
                _db = new TallerContext();
                _db.Entry(m).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index", "Marcas", new { id = m.Id });
            }
            return View(m);
        }

        [HttpGet]
        public ActionResult Ver(int id)
        {
            Marca m = null;
            using (_db = new TallerContext())
            {
                m = _db.Marcas.Find(id);
            }
            return View(m);
        }


        [HttpPost]
        public ActionResult Ver()
        {

            return RedirectToAction("Index", "Marcas");
        }
    }



     

}