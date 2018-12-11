using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using System.Data.Entity;
using System.Runtime.InteropServices;
using DAL.Configurations;

namespace DAL
{
    public class KekContext : DbContext
    {
        public KekContext()
            : base("name=KekContext")
        {
            //this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Cooker> Cookers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Sushi> Sushies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Configurations.Add(new OrderConfiguration());
        }
    }
}
