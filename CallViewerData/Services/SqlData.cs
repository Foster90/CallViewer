using CallViewerData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CallViewerData.Services
{
 
        public class SqlData : IIncident //ICallData
    {
            private readonly CallViewerDbContext db;

            public SqlData(CallViewerDbContext db)
            {
                this.db = db;
            }

            //public void Add(Call call)
            //{
            //    db.Call.Add(call);
            //    db.SaveChanges();
            //}

            public void IAdd(Incident incident)
            {
            db.Incident.Add(incident);
            db.SaveChanges();
            }

            //public void Delete(int id)
            //{

            //    var call = db.Call.Find(id);
            //    db.Call.Remove(call);
            //    db.SaveChanges();
               

            //}

            public void IDelete(int id)
             {

            var incident = db.Incident.Find(id);
            db.Incident.Remove(incident);
            db.SaveChanges();


            }


            //public Call Get(int id)
            //{
            //    return db.Call.FirstOrDefault(n => n.CallID == id);
            //}

            public Incident IGet(int id)
            {
            return db.Incident.FirstOrDefault(n => n.IncidentID == id);
            }



            //public IEnumerable<Call> GetAll()
            //{
            //    return db.Call;
            //}

            public IEnumerable<Incident> IGetAll()
            {
            return db.Incident;
            }



            //public void Update(Call call)
            //{
            //    var entry = db.Entry(call);
            //    entry.State = System.Data.Entity.EntityState.Modified;
            //    db.SaveChanges();

            //}

            public void IUpdate(Incident incident)
            {
            var entry = db.Entry(incident);
            entry.State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            }

         
    }
    
}
