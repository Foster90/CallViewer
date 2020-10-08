using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CallViewerData.Models;
using CallViewerData.Services;

namespace CallViewer.Controllers
{
    public class RequestsController : Controller
    {
        private readonly IRequest db;

        public RequestsController(IRequest db)
        {
            this.db = db;
        }
        public ActionResult Index()
        {
            var model = db.RGetAll();
            return View(model);
        }
    }
}