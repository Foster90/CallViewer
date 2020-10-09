using CallViewerData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallViewerData.Services
{
    public interface IIncident
    {
        IEnumerable<Incident> IGetAll();
        Incident IGet(int id);
        void IAdd(Incident incident);
        void IUpdate(Incident incident);
        void IDelete(int id);

    }
}
