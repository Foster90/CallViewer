using CallViewerData.Models;
using System;
using System.Collections.Generic;

namespace CallViewerData.Services
{
    public class InMemoryNovelData : INovelData
    {

        List<Novel> novels;

        public InMemoryNovelData()
        {
            novels = new List<Novel>()
            {
                new Novel { NovelID = 1, Title = "The Place", Author = "Jack Sprat", Price = 22 },
                new Novel { NovelID = 3, Title = "The Place", Author = "Jack Sprat", Price = 22 }
            };
                      

        }

        public IEnumerable<Novel> GetAll()
        {
            return novels;
        }
    }

}
