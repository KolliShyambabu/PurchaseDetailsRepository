using PurchaseDetails.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseDetails.DAL
{
  
    
        public class ProjectDbContext : DbContext
        {
            public ProjectDbContext() : base("DefaultConnection") { }

            public DbSet<ProjectDbContext> PurchaseBilldetails { get; set; }
        }
   
}
