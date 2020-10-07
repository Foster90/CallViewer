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
        //public DbSet<Novel> Novel { get; set; }
        public DbSet<Call> Call { get; set; }


    }
}
