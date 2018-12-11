using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using DAL.Entities;

namespace DAL.Configurations
{
    public class OrderConfiguration : EntityTypeConfiguration<Order>
    {
        public OrderConfiguration()
        {
            HasRequired(c => c.Cooker)
                .WithMany(a => a.Orders)
                .HasForeignKey(c => c.CookerId)
                .WillCascadeOnDelete(false);
        }
    }
}
