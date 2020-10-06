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
        Novel Get(int id);
        void Add(Novel novel);
        void Update(Novel novel);


    }

}
