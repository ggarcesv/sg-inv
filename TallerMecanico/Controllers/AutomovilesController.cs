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

        private TallerContext _db = new TallerContext();
     
        [HttpGet]
        public ActionResult Index()
        {
            IEnumerable<Automovil> Automoviles = null;
            _db = new TallerContext();
            Automoviles = _db.Automoviles.ToList();
            return View(Automoviles);
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
                _db.Automoviles.Add(auto);
                _db.SaveChanges();
                return RedirectToAction("Index", "Automoviles");
            }
            return View(auto);
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            Automovil auto = null;
            using (_db = new TallerContext())
            {
                auto = _db.Automoviles.Find(id);
            }
            return View(auto);
        }

        [HttpPost]
        public ActionResult Edit(int id, Automovil auto)
        {
            if (ModelState.IsValid)
            {
                _db = new TallerContext();
                _db.Entry(auto).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index", "Automoviles", new { id = auto.Id });
            }
            return View(auto);
        }
      
        [HttpGet]
        public ActionResult Ver(int id)
        {
            Automovil auto = null;
            using (_db = new TallerContext())
            {
                auto = _db.Automoviles.Find(id);
            }
            return View(auto);
        }


        [HttpPost]
        public ActionResult Ver()
        {

            return RedirectToAction("Index", "Automoviles");
        }
    }
}