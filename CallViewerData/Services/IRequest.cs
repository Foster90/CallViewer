using CallViewerData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallViewerData.Services
{
    public interface IRequest
    {
        IEnumerable<Request> RGetAll();
        Request RGet(int id);
        void RAdd(Request request);
        void RUpdate(Request request);
        void RDelete(int id);
    }
}
