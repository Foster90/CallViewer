using CallViewerData.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallViewerData.Services
{
    public interface INovelData
    {
        IEnumerable<Novel> GetAll();

    }

}
