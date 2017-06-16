using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContactManagementSystem.Models
{
    public class CMSDbContext : DbContext
    {
        public CMSDbContext()
            : base("myConnectionString")
        { 
        
        }

        public DbSet<ContactInfoModel> Contacts { get; set; }


    }
}