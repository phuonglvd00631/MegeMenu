using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MegaMenu.Models
{
    public class MegaMenuDbContext : DbContext
    {
        public DbSet<Categories> Categories { get; set; }
    }
}