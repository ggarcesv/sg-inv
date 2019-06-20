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
                _db = new TallerContext();// por aqui guardamos en la base de datos
                _db.Marcas.Add(m);
                _db.SaveChanges();
                return RedirectToAction("Index", "Marcas");
            }
            return View(m);
        }


        [HttpGet]
        public ActionResult Edit(int id, Marca m)
        {
            using (_db=new TallerContext())
            {
                m = _db.Marcas.Find(id);
            }
            return View(m);
        }

        [HttpPost]
        public ActionResult Edit(int id)
        {
            Marca m = null;
            if (ModelState.IsValid)
            {
                //_db = new TallerContext();
                //_db.Entry(m).State = System.Data.EntityState.Modified;  // por aqui guardamos en la base de datos
                //_db.SaveChanges();
                //return RedirectToAction("View", "Marcas", new { id = m.id });
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