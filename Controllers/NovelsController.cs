using CallViewerData.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CallViewer.Controllers
{
    public class NovelsController : Controller
    {

        private readonly INovelData db;

        public NovelsController(INovelData db)
        {
            this.db = db;
        }




        // GET: Novels
        public ActionResult Index()
        {

            var model = db.GetAll();
            return View(model);
        }
    }
}