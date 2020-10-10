using CallViewerData.Models;
using CallViewerData.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace CallViewer.Controllers
{


    public class IncidentsController : Controller
    {
        private readonly IIncident db;

        public IncidentsController(IIncident db)
        {
            this.db = db;
        }


        [HttpGet]
        public ActionResult Index()
        {

            var model = db.IGetAll();
            return View(model);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var model = db.IGet(id);
            if (model == null)
            {

                return View("NotFound");

            }
            return View(model);

        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Incident incident)
        {

            if (ModelState.IsValid)
            {
                db.IAdd(incident);
                return RedirectToAction("Details", new { id = incident.IncidentID });
            }

            return View();
        }


        public ActionResult Edit(int id)
        {

            var model = db.IGet(id);
            if (model == null)
            {
                return HttpNotFound();

            }

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Incident incident)
        {

            if (ModelState.IsValid)
            {
                db.IUpdate(incident);
                return RedirectToAction("Details", new { id = incident.IncidentID });
            }

            return View(incident);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {

            var model = db.IGet(id);
            if (model == null)
            {
                return HttpNotFound();

            }

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection form)
        {

            db.IDelete(id);
            return RedirectToAction("Index");
        }


     

    }
}