using CallViewerData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallViewerData.Services
{
    //public class SqlNovelData : INovelData
    //{
    //    private readonly CallViewerDbContext db;

    //    public SqlNovelData(CallViewerDbContext db)
    //    {
    //        this.db = db;
    //    }

    //    public void Add(Novel novel)
    //    {
    //        db.Novel.Add(novel);
    //        db.SaveChanges();
    //    }

    //    public Novel Get(int id)
    //    {
    //        return db.Novel.FirstOrDefault(n => n.NovelID == id);
    //    }

    //    public IEnumerable<Novel> GetAll()
    //    {
    //        return db.Novel;
    //    }

    //    public void Update(Novel novel)
    //    {
    //        var entry = db.Entry(novel);
    //        entry.State = System.Data.Entity.EntityState.Modified;
    //        db.SaveChanges();

    //    }
    //}
}
