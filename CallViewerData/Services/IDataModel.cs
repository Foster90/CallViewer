using CallViewerData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallViewerData.Services
{
    public interface IDataModel
    {

        IEnumerable<Incident> MGetAll();
        IEnumerable<Request> DGetAll();

    }
}
