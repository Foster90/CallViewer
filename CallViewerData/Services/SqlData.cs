using CallViewerData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CallViewerData.Services
{
 
        public class SqlData : IIncident, IRequest, IDataModel
    {
            private readonly CallViewerDbContext db;

            public SqlData(CallViewerDbContext db)
            {
                this.db = db;
            }

        public void RAdd(Request request)
        {
            db.Request.Add(request);
            db.SaveChanges();
        }

        public void IAdd(Incident incident)
            {
            db.Incident.Add(incident);
            db.SaveChanges();
            }

        public void RDelete(int id)
        {

            var call = db.Request.Find(id);
            db.Request.Remove(call);
            db.SaveChanges();


        }

        public void IDelete(int id)
             {

            var incident = db.Incident.Find(id);
            db.Incident.Remove(incident);
            db.SaveChanges();


            }


        public Request RGet(int id)
        {
            return db.Request.FirstOrDefault(n => n.RequestID == id);
        }

        public Incident IGet(int id)
            {
            return db.Incident.FirstOrDefault(n => n.IncidentID == id);
            }



        public IEnumerable<Request> RGetAll()
        {
            return db.Request;
        }

        public IEnumerable<Incident> IGetAll()
            {
            return db.Incident;
            }



        public void RUpdate(Request request)
        {
            var entry = db.Entry(request);
            entry.State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

        }

        public void IUpdate(Incident incident)
            {
            var entry = db.Entry(incident);
            entry.State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            }

        public IEnumerable<Incident> MGetAll()
        {
            return db.Incident;
        }

        public IEnumerable<Request> DGetAll()
        {
            return db.Request;
        }
    }
    
}
