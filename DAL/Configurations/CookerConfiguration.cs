using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using DAL.Entities;

namespace DAL.Configurations
{
    class CookerConfiguration : EntityTypeConfiguration<Cooker>
    {
        public CookerConfiguration()
        {

        }
    }
}

