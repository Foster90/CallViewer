using CallViewerData.Models;
using CallViewerData.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CallViewer.Controllers
{
    public class CallsController : Controller
    {
        private readonly ICallData db;

        public CallsController(ICallData db)
        {
            this.db = db;
        }


        [HttpGet]
        public ActionResult Index()
        {

            var model = db.GetAll();
            return View(model);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var model = db.Get(id);
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
        public ActionResult Create(Call call)
        {

            if (ModelState.IsValid)
            {
                db.Add(call);
                return RedirectToAction("Details", new { id = call.CallID });
            }

            return View();
        }


        public ActionResult Edit(int id)
        {

            var model = db.Get(id);
            if (model == null)
            {
                return HttpNotFound();

            }

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Call call)
        {

            if (ModelState.IsValid)
            {
                db.Update(call);
                return RedirectToAction("Details", new { id = call.CallID });
            }

            return View(call);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {

            var model = db.Get(id);
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

            db.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
