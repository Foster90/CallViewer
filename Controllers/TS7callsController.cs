using CallViewer.Models;
using CallViewerData.Extensions;
using CallViewerData.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CallViewer.Controllers
{
    public class TS7callsController : Controller
    {

        static DataTable dataTable = new DataTable();
        static string str = ConfigurationManager.ConnectionStrings["CallViewerDbContext"].ConnectionString;
        static string sql = @"SELECT i.[Incident ID],i.[Title],i.[Description],g.[Group Name] FROM [TransportTest].[Fact].[Incident] i 
                        inner join [Dimension].[Group] g ON g.[Group Key] = i.[Latest Assignment Group Key] 
                        where g.[Group Name] = 'HAM_TS7_TS7 Support'";

        DataTable filldata = CreateDatatable.CreateCommand(sql, str, dataTable);
       


        public ActionResult Index()
        {

            var model = TS7callsModel.ConvertToTable(filldata);

            return View(model);
        }
    }
}