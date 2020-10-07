using CallViewerData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CallViewerData.Services
{
 
        public class SqlData : ICallData
        {
            private readonly CallViewerDbContext db;

            public SqlData(CallViewerDbContext db)
            {
                this.db = db;
            }

            public void Add(Call call)
            {
                db.Call.Add(call);
                db.SaveChanges();
            }

            public void Delete(int id)
            {

                var call = db.Call.Find(id);
                db.Call.Remove(call);
                db.SaveChanges();
               

            }

        public Call Get(int id)
            {
                return db.Call.FirstOrDefault(n => n.CallID == id);
            }

            public IEnumerable<Call> GetAll()
            {
                return db.Call;
            }

            public void Update(Call call)
            {
                var entry = db.Entry(call);
                entry.State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }
        }
    
}
