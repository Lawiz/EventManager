using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EvenPlaning2.Data;
using EvenPlaning2.Data.DataModels;
using EvenPlaning2.Models.EventViewModels;
using Microsoft.AspNetCore.Identity;
using EvenPlaning2.Models;
using Microsoft.EntityFrameworkCore;

namespace EvenPlaning2.Controllers
{
    public class EventManagerController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private ApplicationDbContext  db { get; set; }
        public EventManagerController(ApplicationDbContext db,
            UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            this.db = db;
        }
        // GET: EventManager
        public ActionResult Index()
        {
            var model = db.EventModel
                .Include(c => c.EventInfo)
                    .Include(g => g.SubThems)
                    .Include(u => u.applicationUser).Select(p => new IndexEventViewModel()
                    {
                        Name = p.Name,
                        Id = p.Id,
                        MainThem = p.MainTheme,
                        EvenDate = p.EventInfo.DateEvent,
                        SignedUp = p.EventInfo.CountOfPartesipantes,
                        MaxPartesipantes = p.EventInfo.MaxCountOfPartesipantes
            }).ToList();
            return View("Index",model);
        }

        // GET: EventManager/Details/5
        public ActionResult Details(string id)
        {
            var EventFromDb = db.EventModel
                .Include(s=>s.SubThems)
                .Include(i=>i.EventInfo)
                .Include(u=>u.applicationUser)
                .SingleOrDefault(p => p.Id == id);

           

            return View("Details",EventFromDb);
        }

        // GET: EventManager/Create
        
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: EventManager/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EventModel model,List<string> SubThems)
        {
            try
            {
                // TODO: Add insert logic here
                model.SubThems = SubThems.Select(p=>new SubThem() { SubThemValue=p}).ToList();
                model.applicationUser = _userManager.GetUserAsync(User).Result;
                db.EventModel.Add(model);
                db.SaveChanges();
              

                return View("Index");
            }
            catch(Exception ex)
            {
                return View("Error");
            }
        }
        public string Enroll(string id)
        {
            try
            {
                var curEvent = db.EventModel
                        .Include(c => c.EventInfo)
                        .Include(g => g.SubThems)
                        .Include(u => u.applicationUser)
                    .SingleOrDefault(p => p.Id == id);
                curEvent.EventInfo.CountOfPartesipantes += 1;
                db.SaveChanges();
                return "Dud";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public bool AnEnroll(string id)
        {
            try
            {
                var curEvent = db.EventModel
                        .Include(c => c.EventInfo)
                        .Include(g => g.SubThems)
                        .Include(u => u.applicationUser)
                    .SingleOrDefault(p => p.Id == id);
                curEvent.EventInfo.CountOfPartesipantes -=1;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        // POST: EventManager/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id)
        {
            try
            {
                // TODO: Add delete logic here
                var parent = db.EventModel
                    .Include(c=>c.EventInfo)
                    .Include(g=>g.SubThems)
                    .Include(u=>u.applicationUser)
                    .SingleOrDefault(p => p.Id == id);
                db.EventModel.Remove(parent);
                db.SaveChanges();
                return RedirectPermanent("Index");
            }
            catch(Exception ex)
            {
                return View("Error",new ErrorViewModel() { RequestId=ex.Message});
            }
        }
    }
}