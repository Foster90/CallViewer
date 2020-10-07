//using CallViewerData.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace CallViewerData.Services
//{
//    public class InMemoryNovelData : INovelData
//    {

//        List<Novel> novels;

//        public InMemoryNovelData()
//        {
//            novels = new List<Novel>()
//            {
//                new Novel { NovelID = 1, Title = "The Place", Author = "Jack Sprat", Price = 22 },
//                new Novel { NovelID = 3, Title = "The Place", Author = "Jack Sprat", Price = 22 }
//            };
                      

//        }

//        public void Add(Novel novel)
//        {
//            novels.Add(novel);
//            novel.NovelID = novels.Max(n => n.NovelID) + 1;
//        }

//        public Novel Get(int id)
//        {
//            return novels.FirstOrDefault(n => n.NovelID == id);
//        }

//        public IEnumerable<Novel> GetAll()
//        {
//            return novels;
//        }

//        public void Update(Novel novel)
//        {
//            var existing = Get(novel.NovelID);
//            if(existing != null)
//            {

//                existing.Title = novel.Title;
//                existing.Author = novel.Author;
//                existing.Price = novel.Price;


//            }
//        }
//    }

//}
