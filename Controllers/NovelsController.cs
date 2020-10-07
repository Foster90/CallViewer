//using CallViewerData.Models;
//using CallViewerData.Services;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace CallViewer.Controllers
//{
//    public class NovelsController : Controller
//    {

//        private readonly INovelData db;

//        public NovelsController(INovelData db)
//        {
//            this.db = db;
//        }


//        [HttpGet]
//        public ActionResult Index()
//        {

//            var model = db.GetAll();
//            return View(model);
//        }

//        [HttpGet]
//        public ActionResult Details(int id)
//        {
//            var model = db.Get(id);
//            if (model == null)
//            {

//                return View("NotFound");

//            }
//            return View(model);

//        }

//        [HttpGet]
//        public ActionResult Create()
//        {
//            return View();
//        }

//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create(Novel novel)
//        {       

//            if (ModelState.IsValid)
//            {
//                db.Add(novel);
//                return RedirectToAction("Details", new { id = novel.NovelID});
//            }

//            return View();
//        }


//        public ActionResult Edit(int id)
//        {

//            var model = db.Get(id);
//            if (model == null)
//            {
//                return HttpNotFound();

//            }         
                        
//            return View(model);
//        }


//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit(Novel novel)
//        {

//            if (ModelState.IsValid)
//            {
//                db.Update(novel);
//                return RedirectToAction("Details", new { id = novel.NovelID });
//            }

//            return View(novel);
//        }
//    }
//}