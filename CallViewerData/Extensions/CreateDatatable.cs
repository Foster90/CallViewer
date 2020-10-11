using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CallViewerData.Extensions
{
    public class CreateDatatable
    {

        public static DataTable CreateCommand(string queryString, string connectionString, DataTable datatable)
        {
            using (SqlConnection connection = new SqlConnection(
                       connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                using (SqlDataAdapter sql = new SqlDataAdapter(command))
                {
                    sql.Fill(datatable);
                }

                return datatable;
            }
        }


    }
}
