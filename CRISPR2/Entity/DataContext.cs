using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRISPR2.Entity
{
    public class DataContext : DbContext
    {
        public DataContext() : base("dataConnection")
        {
            Database.SetInitializer(new DataInitializer());
        }
        public DbSet<ImplementType> ImplementType { get; set; }
        public DbSet<Organism> Organism { get; set; }
        public DbSet<Order> Order { get; set; }

        public DbSet<Sgrna> Sgrna { get; set; }

        public DbSet<Offtarget> OffTarget { get; set; }

    }
}