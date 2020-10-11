using CallViewerData.Extensions;
using CallViewerData.Services;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;


namespace CallViewer.Models
{

    public class TS7callsModel
    { 
  


        public string IncidentID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string GroupName { get; set; }



        public static IEnumerable<TS7callsModel> ConvertToTable(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                yield return new TS7callsModel
                {
                    IncidentID = Convert.ToString(row["Incident ID"]),
                    Title = Convert.ToString(row["Title"]),
                    Description = Convert.ToString(row["Description"]),
                    GroupName = Convert.ToString(row["Group Name"]),
               
                };
            }

        }



    }
}