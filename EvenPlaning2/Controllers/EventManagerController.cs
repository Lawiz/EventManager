using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EvenPlaning2.Data;
using EvenPlaning2.Data.DataModels;

namespace EvenPlaning2.Controllers
{
    public class EventManagerController : Controller
    {
        private ApplicationDbContext  db { get; set; }
        public EventManagerController(ApplicationDbContext db)
        {
            this.db = db;
        }
        // GET: EventManager
        public ActionResult Index()
        {
            return View("Index",db.EventModel.Select(e=>e).OrderBy(p=>p.EventInfo.DateEvent).ToList());
        }

        // GET: EventManager/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EventManager/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EventManager/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EventModel model)
        {
            try
            {
                // TODO: Add insert logic here
               
                db.EventModel.Add(model);
                db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EventManager/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EventManager/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EventManager/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EventManager/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}