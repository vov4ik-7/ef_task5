using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using DAL.Entities;

namespace DAL.Configurations
{
    public class SushiConfiguration : EntityTypeConfiguration<Sushi>
    {
        public SushiConfiguration()
        {
            HasRequired(c => c.Order)
                .WithMany(a => a.Sushies)
                .HasForeignKey(c => c.OrderId)
                .WillCascadeOnDelete(false);
        }
    }
}
