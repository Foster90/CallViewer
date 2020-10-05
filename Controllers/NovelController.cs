using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CallViewer.Controllers
{
    public class NovelController : Controller
    {
        // GET: Novel
        public ActionResult Index()
        {
            DataTable dt = new DataTable();

            string str =  ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;


                using (SqlConnection cn = new SqlConnection(str))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Novel"))
                    {

                        cmd.Connection = cn;
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);

                        }

                    }



                }
                          
            return View(dt);

        }
    }
}