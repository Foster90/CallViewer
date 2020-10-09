using CallViewer.Models;
using CallViewerData.Models;
using CallViewerData.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CallViewer.Controllers
{
    public class HomeController : Controller
    {

        IDataModel db;

        public HomeController(IDataModel db)
        {
            this.db = db;
        }

        public ActionResult Index()
        {
            var model = PrepareViewModel();
            return View(model);
        }


        private DataModel PrepareViewModel()
        {
            return new DataModel
            {
                allIncidents = db.MGetAll(),
                allRequests = db.DGetAll()
            };
        }

    }
}