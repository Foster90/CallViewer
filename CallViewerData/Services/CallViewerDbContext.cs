using CallViewerData.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallViewerData.Services
{
    public class CallViewerDbContext : DbContext
    {
        
        public DbSet<Incident> Incident { get; set; }
        public DbSet<Request> Request { get; set; }

       


    }
}
