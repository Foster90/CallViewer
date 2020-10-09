using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallViewerData.Models
{
    public class DataModel
    {

        public IEnumerable<Incident> allIncidents { get; set; }
        public IEnumerable<Request> allRequests { get; set; }

    }
}
